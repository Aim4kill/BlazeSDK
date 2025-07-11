using ProtoFire.Tls;

namespace ProtoFire;

public interface IProtoFireHandler
{
    /// <summary>
    /// This method is called when a connection has been made.
    /// </summary>
    /// <param name="connection">The connection that was made</param>
    /// <returns>True if the connection should be kept, false if it should be disconnected</returns>
    Task<bool> OnConnectedAsync(ProtoFireConnection connection);

    /// <summary>
    /// This method is called when a connection has been made and a certificate is required.
    /// </summary>
    /// <param name="connection">The connection which requires certificate</param>
    /// <returns>The certificate to use, or null if no certificate is available</returns>
    /// <remarks>Used only for server connections</remarks>
    ProtoSSLCertificate? SelectCertificate(ProtoFireConnection connection);

    /// <summary>
    /// This method is called when a connection stream has been authenticated and is ready to communicate with the endpoint.
    /// </summary>
    /// <param name="connection">The connection which recently connected</param>
    /// <param name="secure">True if the connection is secure (SSL/TLS), false if it is insecure</param>
    Task OnAuthenticatedAsync(ProtoFireConnection connection, bool secure);

    /// <summary>
    /// This method is called when a connection is lost.
    /// </summary>
    /// <param name="connection">The connection which was lost</param>
    Task OnDisconnectedAsync(ProtoFireConnection connection);

    /// <summary>
    /// This method is called when a connection sends a packet.
    /// </summary>
    /// <param name="connection">The connection which sent the packet</param>
    /// <param name="packet">The packet that was sent</param>
    Task OnPacketSentAsync(ProtoFireConnection connection, ProtoFirePacket packet);

    /// <summary>
    /// This method is called when a connection receives a packet.
    /// </summary>
    /// <param name="connection">The connection which received the packet</param>
    /// <param name="packet">The packet that was received</param>
    Task OnPacketReceivedAsync(ProtoFireConnection connection, ProtoFirePacket packet);

    /// <summary>
    /// This method is called when an error has occurred in the connection. The connection may be lost shortly after this method is called.
    /// </summary>
    /// <param name="connection">The connection which encountered the exception</param>
    /// <param name="exception">The exception that was thrown</param>
    Task OnErrorAsync(ProtoFireConnection connection, Exception exception);
}
