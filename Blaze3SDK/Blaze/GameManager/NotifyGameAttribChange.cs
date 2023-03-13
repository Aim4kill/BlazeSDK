using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct NotifyGameAttribChange
    {
        /*
        struct __cppobj Blaze::GameManager::NotifyGameAttribChange : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttribs;
        };

        Blaze::GameManager::NotifyGameAttribChange {
	        TdfMap ATTR
	        TdfInt(unsigned int) GID = 0
        }

         */

        [TdfMember("GID")]
        public uint mGameId;

        [TdfMember("ATTR")]
        public SortedDictionary<string, string> mGameAttribs;
    }
}
