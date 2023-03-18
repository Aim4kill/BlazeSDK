using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
	[TdfStruct]
	public struct ReplicatedCachedMemberInfo
	{

		[TdfMember("SNTD")]
		public uint mMembershipSinceTime;

		[TdfMember("MSTA")]
		public MembershipStatus mMembershipStatus;

		[TdfMember("MMDA")]
		public SortedDictionary<string, string> mMetaData;

	}
}
