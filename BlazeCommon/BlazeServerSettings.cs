using System.Net;
using System.Security.Cryptography.X509Certificates;
using Tdf;

namespace BlazeCommon
{
    public delegate void ConnectionDelegate(BlazeConnectionInfo connectionInfo);

    public class BlazeServerSettings
    {
        public string Name { get; }
        public IPEndPoint LocalEP { get; }
        public X509Certificate? Certificate { get; set; }
        public ITdfEncoder Encoder { get; }
        public ITdfDecoder Decoder { get; }
        public int ComponentNotFoundErrorCode { get; set; }
        public int CommandNotFoundErrorCode { get; set; }
        public int ErrSystemErrorCode { get; set; }
        public ConnectionDelegate? OnNewConnection { get; set; }
        public ConnectionDelegate? OnDisconnected { get; set; }


        public BlazeServerSettings(string name, IPEndPoint endPoint, ITdfEncoder encoder, ITdfDecoder decoder)
        {
            Name = name;
            LocalEP = endPoint;
            Encoder = encoder;
            Decoder = decoder;

            //Taken from Blaze 3
            ComponentNotFoundErrorCode = 1073872896;
            CommandNotFoundErrorCode = 1073938432;
            ErrSystemErrorCode = 1073807360;
        }
    }
}
