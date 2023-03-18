using Tdf;

namespace Blaze3SDK.Blaze
{
	[TdfStruct]
	public struct UserManagerCensusData
	{

		[TdfMember("CPCM")]
		public SortedDictionary<ClientType, uint> mConnectedPlayerCounts;

	}
}
