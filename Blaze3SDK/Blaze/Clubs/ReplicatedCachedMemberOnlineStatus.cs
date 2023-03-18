using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
	[TdfStruct]
	public struct ReplicatedCachedMemberOnlineStatus
	{

		[TdfMember("CLID")]
		public uint mClubId;

		[TdfMember("CMOS")]
		public MemberOnlineStatus mMemberOnlineStatus;

	}
}
