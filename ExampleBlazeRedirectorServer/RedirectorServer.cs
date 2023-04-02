using Blaze3SDK;
using Blaze3SDK.Blaze.Redirector;
using BlazeCommon;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using static Blaze3SDK.Components.RedirectorComponent;

namespace ExampleBlazeRedirectorServer
{
    public class RedirectorServer : Blaze3Server
    {
        public RedirectorServer(int port, X509Certificate certificate) : base("gosredirector.ea.com", new IPEndPoint(IPAddress.Any, port), certificate)
        {

        }

        public override void OnProtoFireConnect(ProtoFireConnection connection)
        {
            Console.WriteLine($"New client connected to {Name}");
        }

        public override void OnProtoFireDisconnect(ProtoFireConnection connection)
        {
            Console.WriteLine($"Client disconnected from {Name}");
        }

        public override void OnProtoFireError(ProtoFireConnection connection, Exception exception)
        {
            //This function will be called when an exception happens when executing OnProtoFireConnect/OnProtoFireDisconnect/OnProtoFireError/OnProtoFirePacketReceived
            Console.WriteLine($"Unknown error occured: "+ exception);
        }
        
        public override void OnProtoFirePacketReceived(ProtoFireConnection connection, IBlazePacket packet)
        {
            IBlazePacket response;

            //Display incoming blaze packet
            Console.WriteLine(packet.ToString(Helper, true));

            //Check if blaze packet component is redirector component, if not send ERR_COMPONENT_NOT_FOUND back as response
            if (packet.Frame.Component != (ushort)Component.RedirectorComponent)
            {
                response = packet.CreateResponsePacket((int)GlobalError.ERR_COMPONENT_NOT_FOUND);
                connection.Send(response.ToProtoFirePacket(Encoder));
                return;
            }

            //Check if blaze packet command is getServerInstance, if not send ERR_COMMAND_NOT_FOUND back as response
            if (packet.Frame.Command != (ushort)RedirectorComponentCommand.getServerInstance)
            {
                response = packet.CreateResponsePacket((int)GlobalError.ERR_COMMAND_NOT_FOUND);
                connection.Send(response.ToProtoFirePacket(Encoder));
                return;
            }

            //Now we know that the request is definitely ServerInstanceRequest (Blaze3SDK/Components/RedirectorComponent.cs) (line: 23)
            BlazePacket<ServerInstanceRequest> request = (BlazePacket<ServerInstanceRequest>)packet;
            ServerInstanceRequest requestData = request;

            //access request data, in this case we are simply printing them
            Console.WriteLine($"Service Name     : {requestData.mName}");
            Console.WriteLine($"Client Type      : {requestData.mClientType}");
            Console.WriteLine($"Client Platform  : {requestData.mPlatform}");

            //And depending on what request data there is, decide with what data you want to answer.
            //In our case let's say we want to redirect all clients to insecure(no SSL) 127.0.0.1:33152 Blaze server.
            bool secure = false; //insecure
            string ip = "127.0.0.1";
            ushort port = 33152;


            ServerInstanceInfo responseData = new ServerInstanceInfo()
            {
                //this is an union type, so we specify only one of the values
                mAddress = new ServerAddress() 
                {
                    IpAddress = new IpAddress()
                    {
                        mHostname = ip,
                        mIp = Utils.GetIPAddressAsUInt(ip),
                        mPort = port
                    },
                },

                //optionally address remaps can be specified
                mAddressRemaps = new List<AddressRemapEntry>() 
                {

                },

                //optionally server messages can be specified
                mMessages = new List<string>() {
                    "Hello, have fun!",
                    "    /Aim2Strike/"
                },

                //optionally name remaps can be specified
                mNameRemaps = new List<NameRemapEntry>()
                {

                },
                mSecure = secure, 
                mDefaultDnsAddress = 0
            };

            response = packet.CreateResponsePacket(responseData);

            //Display outgoing blaze packet
            Console.WriteLine(response.ToString(Helper, true));

            //send the response!
            connection.Send(response.ToProtoFirePacket(Encoder));
        }
    }
}
