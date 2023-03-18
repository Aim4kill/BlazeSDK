using Tdf;

namespace Blaze3SDK.Blaze.Clubs
{
	[TdfStruct]
	public struct ReplicatedCachedClubData
	{

		[TdfMember("DMID")]
		public uint mClubDomainId;

		[TdfMember("CLST")]
		public ClubSettings mClubSettings;

		[TdfMember("NAME")]
		public string mName;

	}
}
