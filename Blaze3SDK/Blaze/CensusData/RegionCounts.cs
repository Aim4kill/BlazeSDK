using Tdf;

namespace Blaze3SDK.Blaze.CensusData
{
	[TdfStruct]
	public struct RegionCounts
	{

		[TdfMember("CNOU")]
		public SortedDictionary<string, uint> mNumOfUsersByRegion;

	}
}
