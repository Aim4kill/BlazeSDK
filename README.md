BlazeSDK
========
* [About](#about)
  - [Why?](#why)
* [Project descriptions](#project-descriptions)
* [BlazeComponentBaseGenerator](#blazecomponentbasegenerator)
* [Blaze2SDK](#blaze2sdk)
* [Blaze3SDK](#blaze3sdk)

## About
Heavy work in progress BlazeSDK, that can be used to create a Blaze Server or any other project related to Blaze.
### Why?
I wanted to create a blaze library where i can:
  *  __See the whole blaze packet data in a [nice readable format](https://user-images.githubusercontent.com/76944477/229182210-f11edb3d-87b8-4f98-8a52-a08b36df6287.png)__.
  *  __Forget about the Tdf tags and their [base types](Tdf/TdfBaseType.cs) when using [Tdf structs](https://user-images.githubusercontent.com/76944477/229182379-994242b9-f9e3-4604-8c82-8b274dc3fe10.png)__. Also now you can see the true meaning behind the Tdf tags (previously looking at the tdf tags, in some cases it was hard to understand what they mean, but now with field names it is much better to understand them).
  *  __Work better with integer types__
      - All booleans, enums, bitfields are under integer type, which means they all are represented by numbers. Now it is possible to know the actual type behind Tdf integer value and work with them better. For example you have [ClientType](Blaze3SDK/Blaze/ClientType.cs) enum value = 2. Now you know that it is actually CLIENT_TYPE_DEDICATED_SERVER.
      - Now there are integer limits (Blaze 3). Usually Tdf varsize integer encoding allows encoding any integer value, but now you can't (which is a good thing!). Lets take for example a look at [IpAddress](Blaze3SDK/Blaze/IpAddress.cs) Tdf structure. If you wanted to set the port (type = unsigned short) to -673 (which is not a valid port), you won't be able to.
  * __Create my own blaze server__ - [Here](ExampleBlazeRedirectorServer/Program.cs) you can see example Blaze 3 redirector server.

## Project descriptions
  * __[Blaze2SDK](#blaze2sdk)__ - SDK for Blaze 2.xx.xx.xx versions. Blaze2SDK is currently being created mainly using information from MOH2010 Beta .pdb.
  * __[Blaze3SDK](#blaze3sdk)__ - SDK for Blaze 3.xx.xx.xx versions. Blaze3SDK is currently being created mainly using information from BF3 Beta .pdb.
  * __BlazeCommon__ - Common files used for Blaze. Can be used to create base for blaze server (only for clients who are using [FireFrame](BlazeCommon/FireFrame.cs) as their packet header (moh2010, mohw, nfstr, bf3, bf4, etc.)).
  * __[BlazeComponentBaseGenerator](#blazecomponentbasegenerator)__ - A Visual Studio extension (Custom Tool) that is used to generate component bases (.cs) from .json description file. So if you need to modify the component data, do not modify the component base .cs file, but the .json file instead and the component base will be auto regenerated.
  * __[ExampleBlazeRedirectorServer](ExampleBlazeRedirectorServer/Program.cs)__ - A example Blaze 3 redirector server which works similary like gosredirector.ea.com:42127.
  * __FixedSsl__ - Used in BlazeCommon project to allow the use of deprecated SSL protocol versions in C# (that some games are using), for example, Ssl3. So there is no need for SSPI patches on host server.
  * __HashLib__ - Used in XI5 project, where SHA224 is needed, which is not natively supported in C#.
  * __Tdf__ - Used to encode and decode Blaze packet Tdf structures.
  * __XI5__ - An extra project provided for decoding and verifying (verification for [RPCN](https://github.com/RipleyTom/rpcn) only!) PS3 tickets that can be found in [PS3LoginRequest](Blaze3SDK/Blaze/Authentication/PS3LoginRequest.cs) Tdf structure.

## BlazeComponentBaseGenerator
:white_check_mark: Finished:
  * Default handlers for server for client requests

:wrench: Todo:
  * Methods for server to send notifications to clients
  * Default handlers for client for server notifications
  * Methods for client to send requests to server
  * Some other stuff.

## Blaze2SDK
:white_check_mark: Finished:
  * All component request/response/error response/notification enums dumped from MOH2010 Beta server files. 
  * All Tdf types dumped from MOH2010 Beta .pdb.

:wrench: Todo:
  * Link all component requests/responses/error responses/notifications to their respective Tdf types.
  * Some other stuff.

## Blaze3SDK
:white_check_mark: Finished:
  * All component request/response/error response/notification enums dumped from latest BF3 server files.
  * All component notification types linked to their respective Tdf types.
  * All Tdf types dumped from BF3 Beta .pdb.

:wrench: Todo:
  * Link all component requests/responses/error responses to their respective Tdf types.
  * Figure out if Tdf id's can be autogenerated for Tdf structs, so that hardcoded ones does not have to be used, which are not even available for all Tdf structures (BF3 Beta).
  * Check out MOHW server files, because it appears that it uses newer Blaze version than BF3 (but still being Blaze 3), maybe there is something useful.
  * Some other stuff.
