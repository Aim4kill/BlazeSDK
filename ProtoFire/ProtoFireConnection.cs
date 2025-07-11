using Org.BouncyCastle.Tls;
using ProtoFire.Frames;
using ProtoFire.Internal;
using ProtoFire.Tls;
using System.Net.Sockets;
using System.Threading.Channels;

namespace ProtoFire;

public class ProtoFireConnection
{
    public Socket Socket { get; }
    public IProtoFireHandler EventHandler { get; }
    public FrameType FrameType { get; }
    public Guid Id { get; } = Guid.NewGuid();
    public bool Connected { get; private set; }
    public object? State { get; set; }

    SemaphoreSlim sendLock;
    Stream _stream;
    Channel<ProtoFirePacket> _channel;

    internal ProtoFireConnection(Socket socket, IProtoFireHandler eventHandler, FrameType frameType)
    {
        Utilities.ValidateFrameType(frameType);

        Socket = socket;
        _stream = new NetworkStream(socket, true);
        FrameType = frameType;

        if (eventHandler is ProtoFireEventHandlerTryWrapper)
            EventHandler = eventHandler;
        else
            EventHandler = new ProtoFireEventHandlerTryWrapper(eventHandler);

        Connected = true;
        sendLock = new SemaphoreSlim(1, 1);
        _channel = Channel.CreateUnbounded<ProtoFirePacket>();
    }

    public async Task ProcessAsync(bool isServer, bool secure)
    {

        try
        {
            if (!Connected)
                throw new InvalidOperationException("Connection has already disconnected");

            if (!await EventHandler.OnConnectedAsync(this).ConfigureAwait(false))
            {
                Disconnect();
                return;
            }

            await Start(isServer, secure).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            await EventHandler.OnErrorAsync(this, ex).ConfigureAwait(false);
        }

        Disconnect();
    }

    Task Start(bool isServer, bool secure)
    {
        if (isServer)
        {
            if(secure)
            {
                ProtoSSLCertificate? certificate = EventHandler.SelectCertificate(this);
                if (certificate == null)
                {
                    Disconnect();
                    return Task.CompletedTask;
                }

                _stream = new ProtoSslServerProtocol(certificate, _stream).Stream;
            }
        }
        else
        {
            if (secure)
            {
                var client = new ProtoFireTlsClient();
                TlsClientProtocol protocol = new TlsClientProtocol(_stream);
                protocol.Connect(client);

                _stream = protocol.Stream;
            }
        }

        // Notify the event handler that the connection has been authenticated
        Task authenticatedTask = EventHandler.OnAuthenticatedAsync(this, secure);

        // (Producer): Reads packets from the network stream and writes them to the channel (for them to be processed by consumer)
        Task readPacketsTask = ReadPacketsAsync();

        // (Consumer): Processes packets from the channel
        Task processPacketsTask = ProcessPacketsAsync();

        return Task.WhenAll(authenticatedTask, readPacketsTask, processPacketsTask);
    }


    async Task ReadPacketsAsync()
    {
        while (Connected)
        {
            ProtoFirePacket? packet = FrameType switch
            {
                FrameType.FireFrame => await ProtoFirePacket.ReadFromAsync<FireFrame>(_stream).ConfigureAwait(false),
                FrameType.Fire2Frame => null, //TODO: Implement Fire2Frame
                _ => null,
            };

            if (packet == null)
            {
                Disconnect();
                break;
            }

            await _channel.Writer.WriteAsync(packet).ConfigureAwait(false);
        }

        _channel.Writer.Complete();
    }

    async Task ProcessPacketsAsync()
    {
        await foreach (ProtoFirePacket packet in _channel.Reader.ReadAllAsync().ConfigureAwait(false))
            await EventHandler.OnPacketReceivedAsync(this, packet).ConfigureAwait(false);
    }


    public bool Send(ProtoFirePacket packet)
    {
        if (!Connected)
            return false;

        if (packet.Frame.Type != FrameType)
            return false;

        sendLock.Wait();
        try
        {
            packet.WriteTo(_stream);
            _stream.Flush();
            EventHandler.OnPacketSentAsync(this, packet).GetAwaiter().GetResult();
            return true;
        }
        catch
        {
            Disconnect();
            return false;
        }
        finally
        {
            sendLock.Release();
        }
    }

    public async Task<bool> SendAsync(ProtoFirePacket packet)
    {
        if (!Connected)
            return false;

        if (packet.Frame.Type != FrameType)
            return false;

        await sendLock.WaitAsync().ConfigureAwait(false);
        try
        {
            // prefiring the event task, so that it can run in parallel while the packet is being sent
            Task t1 = EventHandler.OnPacketSentAsync(this, packet);

            // There is an weird issue when stream is bouncy castle tls stream (no issues with simple network stream): it will not send data using async/await methods when stream at the same time is being read from
            /*
            await packet.WriteToAsync(_stream).ConfigureAwait(false);
            await _stream.FlushAsync().ConfigureAwait(false);
             */

            // So the workaround is to use Task.Run with using sync methods, this might be an even better way, we are combining writing and flushing as one
            Task t2 = Task.Run(() =>
            {
                packet.WriteTo(_stream);
                _stream.Flush();
            });

            await Task.WhenAll(t1, t2).ConfigureAwait(false);
            return true;
        }
        catch(Exception ex)
        {
            await EventHandler.OnErrorAsync(this, ex);
            Disconnect();
            return false;
        }
        finally
        {
            sendLock.Release();
        }
    }

    public void Disconnect()
    {
        if (!Connected)
            return;
        Connected = false;

        try { Socket.Close(); }
        catch { }

        _ = EventHandler.OnDisconnectedAsync(this);
    }
}
