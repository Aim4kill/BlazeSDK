using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Shooter
{
	[TdfStruct]
	public struct GroupReport
	{

		[TdfMember("PLYR")]
		public SortedDictionary<long, EntityReport> mPlayerReports;

		[TdfMember("ATRB")]
		public SortedDictionary<string, float> mStats;

	}
}
