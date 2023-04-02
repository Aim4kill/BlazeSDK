using ExampleBlazeRedirectorServer;
using NLog;
using NLog.Layouts;
using System.Security.Cryptography.X509Certificates;

//set up the logger which is used by ProtoFireBasicServer
LogManager.Setup().LoadConfiguration(builder =>
{
    builder.ForLogger().FilterMinLevel(LogLevel.Debug).WriteToConsole(new SimpleLayout("[${longdate}][${callsite-filename:includeSourcePath=false}(${callsite-linenumber})][${level:uppercase=true}]: ${message:withexception=true}"));
});

//All clients connecting to redirector expects the server to user SSL.
//Load your redirector SSL certificate (not included in the example).
//You will have to create your own SSL certificate and make sure the client is SSL patched to accept it.
byte[] certBytes = File.ReadAllBytes("Certificates\\gosredirector.ea.com.pfx");
X509Certificate cert = new X509Certificate2(certBytes, "password");

//Create RedirectorServer
RedirectorServer redirector = new RedirectorServer(42127, cert);

//Start it!
await redirector.Start(-1, CancellationToken.None).ConfigureAwait(false);



//                                  If all goes well, then output should look like this when someone connects to redirector.

/*

[2023-04-02 23:45:57.1151][ProtoFireBasicServer.cs(45)][INFO]: Starting secure ProtoFireServer("gosredirector.ea.com") on port 42127...
[2023-04-02 23:45:57.8430][ProtoFireBasicServer.cs(50)][INFO]: ProtoFireServer("gosredirector.ea.com") started.
[2023-04-02 23:46:12.9597][ProtoFireBasicServer.cs(132)][INFO]: Connection(1) accepted from 127.0.0.1:65323.
New client connected to gosredirector.ea.com
[2023-04-02 23:46:13.1299][ProtoFireBasicServer.cs(74)][INFO]: Authenticating as server for connection(1).
[2023-04-02 23:46:15.3751][ProtoFireBasicServer.cs(99)][INFO]: Authenticated as server for connection(1). Stream type: "SecureNetworkStream"
<- req: ID[0], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
ServerInstanceRequest = {
  mBlazeSDKBuildDate(BTIM) = "Mar 27 2013 15:31:13"
  mBlazeSDKVersion(BSDK) = "3.15.2.0"
  mClientLocale(LOC) = 1701729619 (0x656E5553)
  mClientName(CLNT) = "bf3 server"
  mClientSkuId(CSKU) = "pc"
  mClientType(CLTP) = CLIENT_TYPE_DEDICATED_SERVER (0x00000002)
  mClientVersion(CVER) = "VeniceXpack50final-1.0-67"
  mConnectionProfile(PROF) = "standardSecure_v3"
  mDirtySDKVersion(DSDK) = "8.14.2.0"
  mEnvironment(ENV) = "prod"
  mFirstPartyId(FPID) = {
  }
  mName(NAME) = "battlefield-3-pc"
  mPlatform(PLAT) = "Windows"
}
Service Name     : battlefield-3-pc
Client Type      : CLIENT_TYPE_DEDICATED_SERVER
Client Platform  : Windows
<- resp: ID[0], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
ServerInstanceInfo = {
  mAddress(ADDR) = {
      mIpAddress(VALU) (union : 0) = {
        mHostname(HOST) = "127.0.0.1"
        mIp(IP) = 2130706433 (0x7F000001)
        mPort(PORT) = 33152 (0x8180)
      }
  }
  mAddressRemaps(AMAP) = [
  ]
  mDefaultDnsAddress(XDNS) = 0 (0x00000000)
  mMessages(MSGS) = [
    [0] = "Hello, have fun!"
    [1] = "    /Aim2Strike/"
  ]
  mNameRemaps(NMAP) = [
  ]
  mSecure(SECU) = false
}
[2023-04-02 23:46:15.7915][ProtoFireBasicServer.cs(146)][INFO]: Connection(1) disconnected.
Client disconnected from gosredirector.ea.com

 */



//                              Same can be seen from the requestor client server logs (in this case bf3 server)

/*
[UTC 04/02/2023 20:46:15.179] BlazeSDK(0): "GameLoop": Info: -> req: ID[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
[UTC 04/02/2023 20:46:15.179] BlazeSDK(0): "GameLoop": Info:   ServerInstanceRequest = {
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     BSDK = "3.15.2.0"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     BTIM = "Mar 27 2013 15:31:13"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     CLNT = "bf3 server"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     CLTP = CLIENT_TYPE_DEDICATED_SERVER (2) (0x00000002)
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     CSKU = "pc"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     CVER = "VeniceXpack50final-1.0-67"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     DSDK = "8.14.2.0"
[UTC 04/02/2023 20:46:15.180] BlazeSDK(0): "GameLoop": Info:     ENV = "prod"
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     FPID (union : 127) = {
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     }
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     LOC = 1701729619 (0x656E5553)
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     NAME = "battlefield-3-pc"
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     PLAT = "Windows"
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:     PROF = "standardSecure_v3"
[UTC 04/02/2023 20:46:15.181] BlazeSDK(0): "GameLoop": Info:   }
[UTC 04/02/2023 20:46:15.747] BlazeSDK(0): "GameLoop": Info: <- resp: ID[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
[UTC 04/02/2023 20:46:15.748] BlazeSDK(0): "GameLoop": Info:   ServerInstanceInfo = {
[UTC 04/02/2023 20:46:15.749] BlazeSDK(0): "GameLoop": Info:     ADDR (union : 0) = {
[UTC 04/02/2023 20:46:15.750] BlazeSDK(0): "GameLoop": Info:       VALU = {
[UTC 04/02/2023 20:46:15.750] BlazeSDK(0): "GameLoop": Info:         HOST = "127.0.0.1"
[UTC 04/02/2023 20:46:15.750] BlazeSDK(0): "GameLoop": Info:         IP = 2130706433 (0x7F000001)
[UTC 04/02/2023 20:46:15.750] BlazeSDK(0): "GameLoop": Info:         PORT = 33152 (0x8180)
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:       }
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     }
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     AMAP = [
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     ]
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     MSGS = [
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:       [0] = "Hello, have fun!"
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:       [1] = "    /Aim2Strike/"
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     ]
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     NMAP = [
[UTC 04/02/2023 20:46:15.751] BlazeSDK(0): "GameLoop": Info:     ]
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info:     SECU = false
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info:     XDNS = 0 (0x00000000)
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info:   }
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info: [ServiceResolver:F8F4DBB0].onGetServerInstance: remove onResolveTimeoutJob job(2)
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info: Connecting to blaze server: 127.0.0.1
[UTC 04/02/2023 20:46:15.752] BlazeSDK(0): "GameLoop": Info: [ConnectionManager:F8FED800].makeBlazeConnection: disconnecting in 20000 ms if fails to connect
[UTC 04/02/2023 20:46:15.753] BlazeSDK(0): "GameLoop": Info: [BlazeConnection:F8FED978].BlazeConnection: Connecting to insecure 127.0.0.1:33152
 */