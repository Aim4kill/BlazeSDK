using BlazeCommon;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Tdf;

namespace Blaze2SDK
{
    public static class Blaze2
    {
        static TdfFactory factory;
        static TdfLegacyEncoder encoder;
        static TdfLegacyDecoder decoder;

        static Blaze2()
        {
            factory = new TdfFactory();
            encoder = factory.CreateLegacyEncoder();
            decoder = factory.CreateLegacyDecoder();
        }

        public static BlazeServer CreateBlazeServer(string name, IPEndPoint endPoint, X509Certificate? certificate = null)
        {
            BlazeServerSettings blaze2Settings = new BlazeServerSettings(name, endPoint, encoder, decoder)
            {
                Certificate = certificate,
                ComponentNotFoundErrorCode = (int)Blaze2RpcError.ERR_COMPONENT_NOT_FOUND,
                CommandNotFoundErrorCode = (int)Blaze2RpcError.ERR_COMMAND_NOT_FOUND,
                ErrSystemErrorCode = (int)Blaze2RpcError.ERR_SYSTEM
            };

            return new BlazeServer(blaze2Settings);
        }
    }
}
