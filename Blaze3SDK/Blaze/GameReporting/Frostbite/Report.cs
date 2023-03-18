using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Frostbite
{
	[TdfStruct]
	public struct Report
	{

		[TdfMember("GAME")]
		public SortedDictionary<string, string> mGameAttributes;

		[TdfMember("CLBS")]
		public SortedDictionary<uint, GroupReport> mGroupReports;

		[TdfMember("PLYR")]
		public SortedDictionary<long, EntityReport> mPlayerReports;

	}
}
