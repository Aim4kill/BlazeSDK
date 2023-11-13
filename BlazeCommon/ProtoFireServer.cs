using FixedSsl;
using NLog;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace BlazeCommon
{
    public abstract class ProtoFireServer
    {
        public string Name { get; private set; }
        public IPEndPoint LocalEP { get; private set; }
        public bool IsRunning { get; private set; }
        public X509Certificate? Certificate { get; private set; }
        public bool ForceSsl { get; private set; }

        [MemberNotNullWhen(true, nameof(Certificate))]
        public bool Secure { get => Certificate != null; }

        private Socket? _listenSocket;
        private long _nextConnectionId;
        private ConcurrentDictionary<long, ProtoFireConnection> _connections;
        private CancellationTokenSource _cancellationTokenSource = new CancellationTokenSource();
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public ProtoFireServer(string name, IPEndPoint localEP, X509Certificate? cert, bool forceSsl)
        {
            Name = name;
            LocalEP = localEP;
            IsRunning = false;
            Certificate = cert;
            ForceSsl = forceSsl;

            _connections = new ConcurrentDictionary<long, ProtoFireConnection>();
            _cancellationTokenSource = new CancellationTokenSource();
            _nextConnectionId = 0;
        }

        public void KillConnection(ProtoFireConnection connection)
        {
            if (connection.Connected)
                connection.Disconnect(); //will call this method again after disconnect
            else
                OnProtoFireDisconnectInternalAsync(connection).GetAwaiter().GetResult();
        }

        public void Stop()
        {
            IsRunning = false;
            _cancellationTokenSource.Cancel();
        }

        public async Task Start(int backlog)
        {
            //check if already running or is cancelled
            if (IsRunning)
                return;

            if (_cancellationTokenSource.IsCancellationRequested)
                _cancellationTokenSource = new CancellationTokenSource();

            //server not running, start it
            try
            {
                _logger.Info($"Starting {(Secure ? "secure" : "insecure")} ProtoFireServer({{Name}}) on port {{Port}}...", Name, LocalEP.Port);
                _listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _listenSocket.Bind(LocalEP);
                _listenSocket.Listen(backlog);
                IsRunning = true;
                _logger.Info("ProtoFireServer({Name}) started.", Name);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Failed to start {(Secure ? "secure" : "insecure")} ProtoFireServer({{Name}}) on port {{Port}}. Perhaps the port is already in use.", Name, LocalEP.Port);
                IsRunning = false;
                return;
            }

            try
            {
                //start accepting connections
                while (!_cancellationTokenSource.Token.IsCancellationRequested)
                {
                    Socket socket = await _listenSocket.AcceptAsync(_cancellationTokenSource.Token).ConfigureAwait(false);
                    long clientId = Interlocked.Increment(ref _nextConnectionId);

                    ProtoFireConnection connection = new ProtoFireConnection(clientId, this, socket);
                    await OnProtoFireConnectInternalAsync(connection).ConfigureAwait(false);
                }
            }
            catch (OperationCanceledException) { }

            IsRunning = false;

            _listenSocket.Close();
            _nextConnectionId = 0;
            //kill all server connections
            foreach (var connection in _connections.Values)
                connection.Disconnect();
            _connections.Clear();

        }

        public async void AuthenticateAsServerCallback(IAsyncResult result)
        {
            ProtoFireConnection connection = (ProtoFireConnection)result.AsyncState!;

            try
            {
                Stream? stream = SslSocket.EndAuthenticateAsServer(result);
                if (stream == null)
                {
                    _logger.Info("Failed to authenticate as server for connection({ClientId}).", connection.ID);
                    connection.Disconnect();
                    return;
                }

                connection.SetStream(stream);

                if (Secure)
                    _logger.Info("Authenticated as server for connection({ClientId}). Stream type: {StreamType}", connection.ID, stream.GetType().Name);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to authenticate as server for connection({ClientId}).", connection.ID);
                connection.Disconnect();
                return;
            }

            while (IsRunning)
            {
                ProtoFirePacket? packet = await connection.ReadPacketAsync().ConfigureAwait(false);

                //disconnected
                if (packet == null)
                    break;

                try { await OnProtoFirePacketReceivedAsync(connection, packet).ConfigureAwait(false); }
                catch (Exception ex) { await OnProtoFireErrorInternalAsync(connection, ex).ConfigureAwait(false); }
            }

            connection.Disconnect();
        }

        public ValueTask KillConnectionAsync(ProtoFireConnection connection)
        {
            if (connection.Connected)
            {
                connection.Disconnect(); //will call this method again after disconnect
                return ValueTask.CompletedTask;
            }

            return OnProtoFireDisconnectInternalAsync(connection);
        }

        private async ValueTask OnProtoFireConnectInternalAsync(ProtoFireConnection connection)
        {
            if (!_connections.TryAdd(connection.ID, connection))
            {
                connection.Disconnect();
                return;
            }

            _logger.Info("Connection({ClientId}) accepted from {RemoteEP}.", connection.ID, connection.Socket.RemoteEndPoint);

            try
            {
                await OnProtoFireConnectAsync(connection).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await OnProtoFireErrorInternalAsync(connection, ex).ConfigureAwait(false);
            }

            if (connection.Connected)
            {
                if (Secure)
                    _logger.Info("Authenticating as server for connection({ClientId}).", connection.ID);

                SslSocket.BeginAuthenticateAsServer(connection.Socket, Certificate, ForceSsl, AuthenticateAsServerCallback, connection);
            }
        }

        private async ValueTask OnProtoFireDisconnectInternalAsync(ProtoFireConnection connection)
        {
            if (!_connections.TryRemove(connection.ID, out _))
                return;

            _logger.Info("Connection({ClientId}) disconnected.", connection.ID);

            try
            {
                await OnProtoFireDisconnectAsync(connection).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                await OnProtoFireErrorInternalAsync(connection, ex).ConfigureAwait(false);
            }
        }


        private async Task OnProtoFireErrorInternalAsync(ProtoFireConnection connection, Exception exception)
        {
            try
            {
                await OnProtoFireErrorAsync(connection, exception).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                //an error occured while handling an error, doesnt sound good...
                await OnProtoFireErrorInternalAsync(connection, ex).ConfigureAwait(false);
            }
        }

        public abstract Task OnProtoFireConnectAsync(ProtoFireConnection connection);
        public abstract Task OnProtoFirePacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet);
        public abstract Task OnProtoFireDisconnectAsync(ProtoFireConnection connection);
        public abstract Task OnProtoFireErrorAsync(ProtoFireConnection connection, Exception exception);
    }
}
