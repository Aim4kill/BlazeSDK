using ProtoFire.Internal;
using ProtoFire.Tls;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;

namespace ProtoFire;

public class ProtoFireServer
{
    public IPEndPoint LocalEP { get; private set; }
    public bool Started { get; private set; }
    public bool Secure { get; init; }
    public FrameType FrameType { get; private set; }
    IProtoFireHandler ConnectionHandler { get; }

    public int Port
    {
        get {

            if (_listenSocket == null)
                return LocalEP.Port;
            
            return _listenSocket.LocalEndPoint switch
            {
                IPEndPoint ep => ep.Port,
                _ => LocalEP.Port
            };
        }
    }

    private Socket? _listenSocket;
    private ConcurrentDictionary<Guid, ProtoFireConnection> _connections;


    public ProtoFireServer(IPEndPoint localEP, IProtoFireHandler handler, FrameType frameType)
    {
        Utilities.ValidateFrameType(frameType);

        FrameType = frameType;
        LocalEP = localEP;


        bool shouldTryWrap = handler is not ProtoFireEventHandlerTryWrapper;

        ConnectionHandler = new ProtoFireServerEventDisconnectHelper(this, handler);
        if (shouldTryWrap)
            ConnectionHandler = new ProtoFireEventHandlerTryWrapper(ConnectionHandler);

        Started = false;

        _connections = new ConcurrentDictionary<Guid, ProtoFireConnection>();
    }

    public async Task StartAsync(int backlog, CancellationToken cancelToken = default)
    {
        if (Started)
            throw new InvalidOperationException("Server is already started");

        try
        {
            _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _listenSocket.Bind(LocalEP);
            _listenSocket.Listen(backlog);
            Started = true;
        }
        catch
        {
            _listenSocket?.Close();
            _listenSocket = null;
            throw;
        }

        try
        {
            while (!cancelToken.IsCancellationRequested)
            {
                Socket clientSocket = await _listenSocket.AcceptAsync(cancelToken).ConfigureAwait(false);
                ProtoFireConnection connection = new ProtoFireConnection(clientSocket, ConnectionHandler, FrameType);
                _connections.TryAdd(connection.Id, connection);
                // processing the connection in the background
                _ = connection.ProcessAsync(true, Secure);
            }
        }
        catch (OperationCanceledException) { /* ignore */ }

        Started = false;

        foreach (ProtoFireConnection connection in _connections.Values)
            connection.Disconnect();

        _connections.Clear();
        _listenSocket.Close();
    }


    internal void OnDisconnected(ProtoFireConnection connection)
    {
        _connections.TryRemove(connection.Id, out _);
    }
}
