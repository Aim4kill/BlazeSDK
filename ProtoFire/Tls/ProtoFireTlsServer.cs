using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Signers;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using ProtoFire.Tls.Crypto;
using System.Net;

namespace ProtoFire.Tls;

internal class ProtoFireTlsServer : DefaultTlsServer
{
    static BcTlsCrypto _crypto = new TlsCryptoWithRC4();
    private ProtoSSLCertificate _certificate;

    public ProtoFireTlsServer(ProtoSSLCertificate certificate) : base(_crypto)
    {
        _certificate = certificate;
    }
    public ProtocolVersion[] SupportedVersions => ProtoSSL.SupportedVersions;
    public ProtocolVersion ServerVersion { get; internal set; } = ProtocolVersion.SSLv3; //minimum version
    public override ProtocolVersion GetServerVersion() => ServerVersion; 
    protected override ProtocolVersion[] GetSupportedVersions() => SupportedVersions;
    public override int[] GetCipherSuites() => ProtoSSL.GetCipherSuites(GetSupportedVersions());
    protected override int[] GetSupportedCipherSuites() => TlsUtilities.GetSupportedCipherSuites(_crypto, GetCipherSuites());

    protected override bool SelectCipherSuite(int cipherSuite)
    {
        int keyExchangeAlgorithm = TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);

        if (KeyExchangeAlgorithm.IsAnonymous(keyExchangeAlgorithm))
            return base.SelectCipherSuite(cipherSuite);

        if (keyExchangeAlgorithm != KeyExchangeAlgorithm.RSA)
            return false;

        return base.SelectCipherSuite(cipherSuite);
    }


    public override void NotifySecureRenegotiation(bool secureRenegotiation)
    {
        secureRenegotiation = true;
        base.NotifySecureRenegotiation(secureRenegotiation);
    }

    protected override TlsCredentialedDecryptor GetRsaEncryptionCredentials()
    {
        return new BcDefaultTlsCredentialedDecryptor(_crypto, _certificate.Certificate, _certificate.PrivateKey);
    }
}
