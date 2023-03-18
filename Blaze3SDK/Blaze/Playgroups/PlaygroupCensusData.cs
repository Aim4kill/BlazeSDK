using Tdf;

namespace Blaze3SDK.Blaze.Playgroups
{
	[TdfStruct]
	public struct PlaygroupCensusData
	{

		[TdfMember("PIPN")]
		public uint mNumOfPlayersInPlaygroup;

		[TdfMember("PGN")]
		public uint mNumOfPlaygroup;

	}
}
