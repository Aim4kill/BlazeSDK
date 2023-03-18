using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
	[TdfStruct]
	public struct OnlineStatusReplicationContext
	{

		[TdfMember("OLDS")]
		public MemberOnlineStatus mOldMemberOnlineStatus;

		[TdfMember("CLID")]
		public uint mOldSpecificClubId;

		[TdfMember("CURE")]
		public UpdateReason mUpdateReason;

	}
}
