using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct IndirectJoinGameSetupContext
    {
        /*
          Blaze::BlazeObjectId mUserGroupId;
          bool mRequiresClientVersionCheck;

        	TdfVector3 GRID
	        TdfBool RPVC = 0
         */

        [TdfMember("GRID")]
        public BlazeObjectId mUserGroupId;

        [TdfMember("RPVC")]
        public bool mRequiresClientVersionCheck;
    }
}