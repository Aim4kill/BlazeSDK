using FixedSsl;
using NLog;
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

        [MemberNotNullWhen(true, nameof(Certificate))]
        public bool Secure { get => Certificate != null; }

        private Socket? _listenSocket;
        private long _nextConnectionId;
        private Dictionary<long, ProtoFireConnection> _connections;
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public ProtoFireServer(string name, IPEndPoint localEP, X509Certificate? cert)
        {
            Name = name;
            LocalEP = localEP;
            IsRunning = false;
            Certificate = cert;

            _connections = new Dictionary<long, ProtoFireConnection>();
            _nextConnectionId = 0;
        }

        public async Task Start(int backlog, CancellationToken cancelToken)
        {
            //check if already running or is cancelled
            if (IsRunning || cancelToken.IsCancellationRequested)
                return;

            //if not, attempt to start the server
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
                while (!cancelToken.IsCancellationRequested)
                {


                    Socket socket = await _listenSocket.AcceptAsync(cancelToken);
                    long clientId = Interlocked.Increment(ref _nextConnectionId);

                    ProtoFireConnection connection = new ProtoFireConnection(clientId, this, socket);

                    _internalConnect(connection);

                    if (Secure)
                        _logger.Info("Authenticating as server for connection({ClientId}).", clientId);
                    SslSocket.BeginAuthenticateAsServer(socket, Certificate, AuthenticateAsServerCallback, connection);
                }
            }
            catch (OperationCanceledException) { }
            IsRunning = false;

            //kill all connections in dictionary
            lock (_connections)
                foreach (var connection in _connections.Values)
                    connection.Disconnect();
        }



        public async void AuthenticateAsServerCallback(IAsyncResult result)
        {
            ProtoFireConnection connection = (ProtoFireConnection)result.AsyncState!;

            try
            {
                Stream stream = SslSocket.EndAuthenticateAsServer(result);
                connection.SetStream(stream);

                if (Secure)
                    _logger.Info("Authenticated as server for connection({ClientId}). Stream type: {StreamType}", connection.ID, stream.GetType().Name);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Failed to authenticate as server for connection({ClientId}).", connection.ID);
                _internalDisconnect(connection);
            }

            while (IsRunning)
            {
                ProtoFirePacket? packet = await connection.ReadPacketAsync().ConfigureAwait(false);

                //disconnected
                if (packet == null)
                    break;

                try { OnProtoFirePacketReceived(connection, packet); } catch (Exception ex) { _internalOnError(connection, ex); }
            }

            connection.Disconnect();
        }

        public void KillConnection(ProtoFireConnection connection)
        {
            if (connection.Disconnected)
                _internalDisconnect(connection);
            else
                connection.Disconnect(); //will call this method again after disconnect
        }


        private void _internalConnect(ProtoFireConnection connection)
        {
            _logger.Info("Connection({ClientId}) accepted from {RemoteEP}.", connection.ID, connection.Socket.RemoteEndPoint);
            lock (_connections)
                _connections.Add(connection.ID, connection);
            try { OnProtoFireConnect(connection); } catch (Exception ex) { _internalOnError(connection, ex); }
        }

        private void _internalDisconnect(ProtoFireConnection connection)
        {
            bool success = false;
            lock (_connections)
                success = _connections.Remove(connection.ID);

            if (success)
            {
                _logger.Info("Connection({ClientId}) disconnected.", connection.ID);
                try { OnProtoFireDisconnect(connection); } catch (Exception ex) { _internalOnError(connection, ex); }
            }
        }

        private void _internalOnError(ProtoFireConnection connection, Exception exception)
        {
            try
            {
                OnProtoFireError(connection, exception);
            }
            catch (Exception ex)
            {
                //an error occured while handling an error, doesnt sound good...
                _internalOnError(connection, ex);
            }
        }

        public abstract void OnProtoFireConnect(ProtoFireConnection connection);
        public abstract void OnProtoFirePacketReceived(ProtoFireConnection connection, ProtoFirePacket packet);
        public abstract void OnProtoFireDisconnect(ProtoFireConnection connection);
        public abstract void OnProtoFireError(ProtoFireConnection connection, Exception exception);
    }
}