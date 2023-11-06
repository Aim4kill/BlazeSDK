using Blaze3SDK;
using BlazeCommon;
using ExampleBlazeRedirectorServer.Components;
using NLog;
using NLog.Layouts;
using System.Net;
using System.Security.Cryptography.X509Certificates;

//Change LogLevel to LogLevel.Info to display packets without their content
LogLevel logLevel = LogLevel.Debug;


//set up the logger which is used by BlazeServer, ProtoFireServer
LogManager.Setup().LoadConfiguration(builder =>
{
    builder.ForLogger().FilterMinLevel(logLevel).WriteToConsole(new SimpleLayout("[${longdate}][${callsite-filename:includeSourcePath=false}(${callsite-linenumber})][${level:uppercase=true}]: ${message:withexception=true}"));
});

//All clients connecting to redirector expects the server to use SSL.
//Load your redirector SSL certificate (not included in the example).
//You will have to create your own SSL certificate and make sure the client is SSL patched to accept it (or use https://github.com/Aim4kill/Bug_OldProtoSSL method)
byte[] certBytes = File.ReadAllBytes("Certificates\\gosredirector.ea.com.pfx");
X509Certificate cert = new X509Certificate2(certBytes, "password");

//Create Blaze Redirector server
BlazeServer redirector = Blaze3.CreateBlazeServer("gosredirector.ea.com", new IPEndPoint(IPAddress.Any, 42127), cert);
redirector.AddComponent<RedirectorComponent>();

//Start it!
await redirector.Start(-1).ConfigureAwait(false);




//                                  If all goes well, then output should look like this when someone connects to redirector.

//                  This was an experiment with making BF4 connecting to it, which was successful (even though mismatching Blaze SDK versions)

/*
[2023-08-23 13:18:17.1819][ProtoFireServer.cs(45)][INFO]: Starting secure ProtoFireServer("gosredirector.ea.com") on port 42127...
[2023-08-23 13:18:17.4925][ProtoFireServer.cs(50)][INFO]: ProtoFireServer("gosredirector.ea.com") started.
[2023-08-23 13:20:47.8448][ProtoFireServer.cs(132)][INFO]: Connection(1) accepted from 127.0.0.1:65381.
[2023-08-23 13:20:47.8537][ProtoFireServer.cs(74)][INFO]: Authenticating as server for connection(1).
[2023-08-23 13:20:48.3156][ProtoFireServer.cs(99)][INFO]: Authenticated as server for connection(1). Stream type: "SecureNetworkStream"
[2023-08-23 13:20:48.5163][BlazeServer.cs(116)][DEBUG]: <- req: ID[0], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
ServerInstanceRequest = {
  mBlazeSDKBuildDate(BTIM) = "Feb  2 2017 23:45:59"
  mBlazeSDKVersion(BSDK) = "13.3.1.2.1"
  mClientLocale(LOC) = 1701729619 (0x656E5553)
  mClientName(CLNT) = "warsaw client"
  mClientSkuId(CSKU) = "pc"
  mClientType(CLTP) = CLIENT_TYPE_GAMEPLAY_USER (0x00000000)
  mClientVersion(CVER) = "Warsaw179547retail-x64-1.0-4900"
  mConnectionProfile(PROF) = "standardSecure_v3"
  mDirtySDKVersion(DSDK) = "13.3.1.2.1"
  mEnvironment(ENV) = "prod"
  mFirstPartyId(FPID) = {
  }
  mName(NAME) = "battlefield-4-pc"
  mPlatform(PLAT) = "Windows"
}
Connection Id    : 1
Service Name     : battlefield-4-pc
Client Type      : CLIENT_TYPE_GAMEPLAY_USER
Client Platform  : Windows
[2023-08-23 13:20:48.9568][BlazeServer.cs(116)][DEBUG]: -> resp: ID[0], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
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
[2023-08-23 13:20:49.0252][ProtoFireServer.cs(146)][INFO]: Connection(1) disconnected.
*/




// Or if you disallow battlefield-4-pc (in the request handler)




/*
[2023-08-23 13:25:27.9708][ProtoFireServer.cs(45)][INFO]: Starting secure ProtoFireServer("gosredirector.ea.com") on port 42127...
[2023-08-23 13:25:28.4810][ProtoFireServer.cs(50)][INFO]: ProtoFireServer("gosredirector.ea.com") started.
[2023-08-23 13:25:32.7676][ProtoFireServer.cs(132)][INFO]: Connection(1) accepted from 127.0.0.1:49289.
[2023-08-23 13:25:32.7781][ProtoFireServer.cs(74)][INFO]: Authenticating as server for connection(1).
[2023-08-23 13:25:32.9360][ProtoFireServer.cs(99)][INFO]: Authenticated as server for connection(1). Stream type: "SecureNetworkStream"
[2023-08-23 13:25:33.1804][BlazeServer.cs(116)][DEBUG]: <- req: ID[2], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001]
ServerInstanceRequest = {
  mBlazeSDKBuildDate(BTIM) = "Feb  2 2017 23:45:59"
  mBlazeSDKVersion(BSDK) = "13.3.1.2.1"
  mClientLocale(LOC) = 1701729619 (0x656E5553)
  mClientName(CLNT) = "warsaw client"
  mClientSkuId(CSKU) = "pc"
  mClientType(CLTP) = CLIENT_TYPE_GAMEPLAY_USER (0x00000000)
  mClientVersion(CVER) = "Warsaw179547retail-x64-1.0-4900"
  mConnectionProfile(PROF) = "standardSecure_v3"
  mDirtySDKVersion(DSDK) = "13.3.1.2.1"
  mEnvironment(ENV) = "prod"
  mFirstPartyId(FPID) = {
  }
  mName(NAME) = "battlefield-4-pc"
  mPlatform(PLAT) = "Windows"
}
Connection Id    : 1
Service Name     : battlefield-4-pc
Client Type      : CLIENT_TYPE_GAMEPLAY_USER
Client Platform  : Windows
[2023-08-23 13:25:33.4578][BlazeServer.cs(116)][DEBUG]: -> err: ID[2], UI[0], RedirectorComponent::getServerInstance [0x0005::0x0001], ERR[REDIRECTOR_UNKNOWN_SERVICE_NAME (0x000B0005)]
ServerInstanceError = {
  mMessages(MSGS) = [
    [0] = "Unknown service name"
  ]
}
[2023-08-23 13:25:33.5141][ProtoFireServer.cs(146)][INFO]: Connection(1) disconnected.

 */

