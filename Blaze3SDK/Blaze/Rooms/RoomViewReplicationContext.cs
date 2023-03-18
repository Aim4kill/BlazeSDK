using Tdf;

namespace Blaze3SDK.Blaze.Rooms
{
	[TdfStruct]
	public struct RoomViewReplicationContext
	{

		[TdfMember("UPRE")]
		public RoomViewUpdateReason mUpdateReason;

		public enum RoomViewUpdateReason : int
		{
			CONFIG_RELOADED = 0,
			USER_ROOM_CREATED = 1,
			USER_ROOM_DESTROYED = 2,
		}

	}
}
