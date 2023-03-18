using Tdf;

namespace Blaze3SDK.Blaze.Rsp
{
	[TdfStruct]
	public struct FinishPurchaseResponse
	{

		[TdfMember("DATE")]
		public TimeSpan mExpirationDate;

		[TdfMember("QUAN")]
		public uint mQuantity;

		[TdfMember("SID")]
		public uint mServerId;

	}
}
