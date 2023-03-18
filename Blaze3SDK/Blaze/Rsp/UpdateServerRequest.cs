using Tdf;

namespace Blaze3SDK.Blaze.Rsp
{
	[TdfStruct]
	public struct UpdateServerRequest
	{

		[TdfMember("EXDA")]
		public TimeSpan mExpirationDate;

		[TdfMember("EXPE")]
		public uint mExpirationPeriod;

		[TdfMember("SID")]
		public uint mServerId;

	}
}
