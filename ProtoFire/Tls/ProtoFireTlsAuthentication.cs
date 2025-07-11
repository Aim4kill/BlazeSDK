using Org.BouncyCastle.Pqc.Crypto.Lms;
using Org.BouncyCastle.Tls;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Tls;

internal class ProtoFireTlsAuthentication : TlsAuthentication
{
    public TlsCredentials GetClientCredentials(CertificateRequest certificateRequest)
    {
        return null!;
    }

    public void NotifyServerCertificate(TlsServerCertificate serverCertificate)
    {
        // Do nothing
        Debug.WriteLine("[ProtoFire]: Server certificate received");
    }
}
