using Tdf;

namespace Blaze3SDK.Blaze.Rooms
{
	[TdfStruct]
	public struct RoomMemberData
	{

		[TdfMember("BZID")]
		public long mBlazeId;

		[TdfMember("ATTR")]
		public SortedDictionary<string, string> mMemberAttributes;

		[TdfMember("RMID")]
		public uint mRoomId;

	}
}
