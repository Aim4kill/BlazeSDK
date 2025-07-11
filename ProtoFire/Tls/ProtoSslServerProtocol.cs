using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Tls;

public class ProtoSslServerProtocol: TlsServerProtocol
{
    private ProtoFireTlsServer _server;
    public ProtoSslServerProtocol(ProtoSSLCertificate certificate, Stream stream) : this(certificate, stream, stream)
    {
    }

    public ProtoSslServerProtocol(ProtoSSLCertificate certificate, Stream inputStream, Stream outputStream) : base(inputStream, outputStream)
    {
        _server = new ProtoFireTlsServer(certificate);
        Accept(_server);
    }

    /// <summary>
    /// Ovverride server hello generator which allows downgrading used server tls version.
    /// The selected version is the max TLS version that supports both clients.
    /// </summary>
    protected override ServerHello GenerateServerHello(ClientHello clientHello, HandshakeMessageInput clientHelloMessage)
    {
        ProtocolVersion clientVersion = clientHello.Version;
        ProtocolVersion[] clientSupportedVersions = TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(clientHello.Extensions);
        if(clientSupportedVersions == null)
        {
            if (clientVersion.IsLaterVersionOf(ProtocolVersion.TLSv12))
                clientVersion = ProtocolVersion.TLSv12;

            clientSupportedVersions = clientVersion.DownTo(ProtocolVersion.SSLv3);
        }
        else
        {
            clientVersion = ProtocolVersion.GetLatestTls(clientSupportedVersions);
        }

        ProtocolVersion[] serverSupportedVersions = _server.SupportedVersions;
        if (serverSupportedVersions == null)
            serverSupportedVersions = [];

        ProtocolVersion negotiatedVersion = _server.GetServerVersion();

        // Choosing the max version that is supported by both client and server
        while(serverSupportedVersions.Length > 0)
        {
            ProtocolVersion serverMaxVersion = ProtocolVersion.GetLatestTls(serverSupportedVersions);

            if (clientSupportedVersions.Contains(serverMaxVersion))
            {
                negotiatedVersion = serverMaxVersion;
                break;
            }

            serverSupportedVersions = removeProtocolVersion(serverSupportedVersions, serverMaxVersion);
        }

        _server.ServerVersion = negotiatedVersion;

        //now base GenerateServerHello will not throw an exception if the server version is not supported by the client, but it will use the common max tls version
        return base.GenerateServerHello(clientHello, clientHelloMessage);
    }

    ProtocolVersion[] removeProtocolVersion(ProtocolVersion[] versions, ProtocolVersion version)
    {
        return versions.Where(v => v != version).ToArray();
    }
}
