using Tdf;

namespace Blaze3SDK.Blaze.Rsp
{
	[TdfStruct]
	public struct ListServersResponse
	{

		[TdfMember("TIME")]
		public TimeSpan mCurrentTime;

		[TdfMember("SLST")]
		public List<Server> mServerList;

	}
}
