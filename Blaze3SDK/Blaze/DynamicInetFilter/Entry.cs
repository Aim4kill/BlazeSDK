using Tdf;

namespace Blaze3SDK.Blaze.DynamicInetFilter
{
	[TdfStruct]
	public struct Entry
	{

		[TdfMember("COMM")]
		public string mComment;

		[TdfMember("GRP")]
		public string mGroup;

		[TdfMember("OWNR")]
		public string mOwner;

		[TdfMember("RID")]
		public uint mRowId;

		[TdfMember("SNET")]
		public CidrBlock mSubNet;

	}
}
