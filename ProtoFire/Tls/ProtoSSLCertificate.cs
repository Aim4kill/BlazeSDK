using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Tls.Crypto.Impl.BC;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ProtoFire.Tls;

public class ProtoSSLCertificate
{
    public AsymmetricKeyParameter PrivateKey { get; }
    public Certificate Certificate { get; }

    public ProtoSSLCertificate(AsymmetricKeyParameter privateKey, Certificate certificate)
    {
        PrivateKey = privateKey;
        Certificate = certificate;
    }

    public ProtoSSLCertificate(X509Certificate2 certificate)
    {
        AsymmetricAlgorithm? privateKey = getPrivateKey(certificate);
        if (privateKey == null)
            throw new ArgumentException("Certificate does not contain a private key");

        try { PrivateKey = DotNetUtilities.GetKeyPair(privateKey).Private; }
        catch (CryptographicException exception)
        {
            throw new ArgumentException("Invalid certificate private key or private key is not exportable (missing X509KeyStorageFlags.Exportable flag).", exception);
        }

        Org.BouncyCastle.X509.X509Certificate serverCertificate = DotNetUtilities.FromX509Certificate(certificate);
        TlsCertificate[] chain = [new BcTlsCertificate(new BcTlsCrypto(new SecureRandom()), serverCertificate.CertificateStructure)];
        Certificate = new Certificate(chain);
    }

    public static ProtoSSLCertificate FromX509Certificate2(X509Certificate2 certificate) => new ProtoSSLCertificate(certificate);

    public X509Certificate2 AsX509Certificate2()
    {
        // TODO
        throw new NotImplementedException();
    }

    static AsymmetricAlgorithm? getPrivateKey(X509Certificate2 certificate)
    {
        // X509Certificate2 has PrivateKey property, but it is deprecated.
        // This function has been created to avoid getting warning about it.

        if (!certificate.HasPrivateKey)
            return null;

        RSA? rsa = certificate.GetRSAPrivateKey();
        if (rsa != null)
            return rsa;

        DSA? dsa = certificate.GetDSAPrivateKey();
        if (dsa != null)
            return dsa;

        ECDsa? ecdsa = certificate.GetECDsaPrivateKey();
        if (ecdsa != null)
            return ecdsa;

        ECDiffieHellman? ecdh = certificate.GetECDiffieHellmanPrivateKey();
        if (ecdh != null)
            return ecdh;

        throw new NotSupportedException("Key algorithm not supported");
    }

    public static implicit operator ProtoSSLCertificate(X509Certificate2 certificate) => new ProtoSSLCertificate(certificate);
}
