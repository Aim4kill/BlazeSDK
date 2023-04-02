using System.Net;
using System.Security.Cryptography.X509Certificates;
using Tdf;

namespace BlazeCommon
{
    public abstract class ProtoFireServer : ProtoFireBasicServer
    {
        TdfEncoder _encoder;
        TdfDecoder _decoder;
        IBlazeHelper _helper;
        
        public ProtoFireServer(string name, IPEndPoint localEP, IBlazeHelper helper, TdfEncoder encoder, TdfDecoder decoder, X509Certificate? cert = null) : base(name, localEP, cert)
        {
            _encoder = encoder;
            _decoder = decoder;
            _helper = helper;
        }

        public override void OnProtoFirePacketReceived(ProtoFireConnection connection, ProtoFirePacket packet)
        {
            IBlazePacket decodedPacket = _helper.Decode(packet, _decoder);
            OnProtoFirePacketReceived(connection, decodedPacket);   
        }

        public abstract void OnProtoFirePacketReceived(ProtoFireConnection connection, IBlazePacket packet);
    }
}
