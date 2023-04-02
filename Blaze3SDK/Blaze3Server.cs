using BlazeCommon;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Tdf;

namespace Blaze3SDK
{
    public abstract class Blaze3Server : ProtoFireServer
    {
        public static TdfEncoder Encoder { get; }
        public static TdfDecoder Decoder { get; }
        public static Blaze3Helper Helper { get; }

        static Blaze3Server()
        {
            TdfFactory factory = TdfFactoryProvider.GetInstance();
            Encoder = factory.CreateEncoder(true);
            Decoder = factory.CreateDecoder(true);
            Helper = new Blaze3Helper();
        }

        public Blaze3Server(string name, IPEndPoint localEP, X509Certificate? cert = null) : base(name, localEP, Helper, Encoder, Decoder, cert)
        {
            
            
        }

    }
}
