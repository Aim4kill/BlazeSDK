using Org.Mentalis.Security.Certificates;
using Org.Mentalis.Security.Ssl;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace FixedSsl
{
    public static class SslSocket
    {
        static SslSocket()
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;
        }

        private const int SSLv3 = 0x0300;
        private const int TLSv1 = 0x0301;
        private static SecureProtocol legacyProtocols = SecureProtocol.Ssl3 | SecureProtocol.Tls1;
        public static async Task<Stream> AuthenticateAsServerAsync(Socket socket, X509Certificate? certificate)
        {


            if (certificate == null)
                return new NetworkStream(socket, true);

            //read first 3 bytes (content type (1 byte) and version (2 bytes)), but do not consume them.
            byte[] buffer = new byte[3];
            await socket.ReceiveAsync(buffer, SocketFlags.Peek).ConfigureAwait(false);

            //FIXME: actual ssl version is not at the beginning of the stream, but later in the stream.
            int version = buffer[1] << 8 | buffer[2];

            if (version == SSLv3 || version == TLSv1)
            {
                SecurityOptions options = new SecurityOptions(legacyProtocols, new Certificate(certificate.Handle), ConnectionEnd.Server);
                SecureSocket ss = new SecureSocket(socket, options);
                return new SecureNetworkStream(ss, true);
            }
            SslStream sslStream = new SslStream(new NetworkStream(socket, true), false);
            await sslStream.AuthenticateAsServerAsync(certificate).ConfigureAwait(false);
            return sslStream;
        }

        public static Stream AuthenticateAsServer(Socket socket, X509Certificate? certificate)
        {

            if (certificate == null)
                return new NetworkStream(socket, true);

            //read first 3 bytes (content type (1 byte) and version (2 bytes)), but do not consume them.
            byte[] buffer = new byte[3];
            socket.Receive(buffer, SocketFlags.Peek);

            //FIXME: actual ssl version is not at the beginning of the stream, but later in the stream.
            int version = buffer[1] << 8 | buffer[2];

            if (version == SSLv3 || version == TLSv1)
            {
                SecurityOptions options = new SecurityOptions(legacyProtocols, Certificate.CreateFromX509Certificate(certificate), ConnectionEnd.Server);
                SecureSocket ss = new SecureSocket(socket, options);
                return new SecureNetworkStream(ss, true);
            }
            SslStream sslStream = new SslStream(new NetworkStream(socket, true), false);
            sslStream.AuthenticateAsServer(certificate);
            return sslStream;
        }

        public static IAsyncResult BeginAuthenticateAsServer(Socket socket, X509Certificate? certificate, AsyncCallback? callback, object? state)
        {
            return AuthenticateAsServerAsync(socket, certificate).AsApm(callback, state);
        }

        public static Stream EndAuthenticateAsServer(IAsyncResult result)
        {
            return ((Task<Stream>)result).Result;
        }

        #region Helpers
        private static IAsyncResult AsApm<T>(this Task<T> task,
                                    AsyncCallback? callback,
                                    object? state)
        {
            if (task == null)
                throw new ArgumentNullException("task");

            var tcs = new TaskCompletionSource<T>(state);
            task.ContinueWith(t =>
            {
                if (t.IsFaulted && t.Exception != null && t.Exception.InnerExceptions != null)
                    tcs.TrySetException(t.Exception.InnerExceptions);
                else if (t.IsCanceled)
                    tcs.TrySetCanceled();
                else
                    tcs.TrySetResult(t.Result);

                if (callback != null)
                    callback(tcs.Task);
            }, TaskScheduler.Default);
            return tcs.Task;
        }
        #endregion
    }
}