using System.ComponentModel.DataAnnotations;
using Tdf;

namespace Blaze2SDK.Blaze.Redirector
{
    [TdfStruct]
    public struct IpAddress
    {
        
        /// <summary>
        /// Max String Length: 128
        /// </summary>
        [TdfMember("HOST")]
        [StringLength(128)]
        public string mHostname;
        
        [TdfMember("IP")]
        public uint mIp;
        
        [TdfMember("PORT")]
        public ushort mPort;
        
    }
}
