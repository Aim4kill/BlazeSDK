using Tdf;

namespace Blaze3SDK.Blaze.GameReporting.Shooter
{
	[TdfStruct]
	public struct EntityReport
	{

		[TdfMember("STAT")]
		public SortedDictionary<string, float> mStats;

	}
}
