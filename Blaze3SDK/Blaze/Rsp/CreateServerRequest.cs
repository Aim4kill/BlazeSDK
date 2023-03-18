using Tdf;

namespace Blaze3SDK.Blaze.Rsp
{
	[TdfStruct]
	public struct CreateServerRequest
	{

		[TdfMember("EXDA")]
		public TimeSpan mExpirationDate;

		[TdfMember("EXPE")]
		public uint mExpirationPeriod;

		[TdfMember("PSAL")]
		public string mPingSiteAlias;

		[TdfMember("UID")]
		public long mUserId;

	}
}
