using Org.BouncyCastle.Security;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Tls.Crypto;
using ProtoFire.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Tls;

internal class ProtoFireTlsClient : DefaultTlsClient
{
    public ProtoFireTlsClient() : base(new TlsCryptoWithRC4())
    {
        
    }


    public override ProtocolVersion[] GetProtocolVersions()
    {
        return ProtoSSL.SupportedVersions;
    }

    protected override ProtocolVersion[] GetSupportedVersions()
    {
        return ProtoSSL.SupportedVersions;
    }

    public override void NotifySelectedPsk(TlsPsk selectedPsk)
    {
        base.NotifySelectedPsk(selectedPsk);
    }

    public override int[] GetCipherSuites()
    {
        return ProtoSSL.GetCipherSuites(GetSupportedVersions());
    }

    public override void NotifySecureRenegotiation(bool secureRenegotiation)
    {
        secureRenegotiation = true;
        base.NotifySecureRenegotiation(secureRenegotiation);
    }

    public override TlsAuthentication GetAuthentication()
    {
        return new ProtoFireTlsAuthentication();
    }
}
