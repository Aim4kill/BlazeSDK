using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct CreateGameResponse
    {
        //TdfInt(unsigned int) GID = 0
        //unsigned int mGameId;

        [TdfMember("GID")]
        public uint mGameId;
    }
}
