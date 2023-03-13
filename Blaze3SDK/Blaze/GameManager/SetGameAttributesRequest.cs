using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct SetGameAttributesRequest
    {
        /*
        Blaze::GameManager::SetGameAttributesRequest {
	        TdfMap ATTR
	        TdfInt(unsigned int) GID = 0
        }

        struct __cppobj Blaze::GameManager::SetGameAttributesRequest : Blaze::Tdf
        {
          unsigned int mGameId;
          Blaze::TdfPrimitiveMap<Blaze::TdfString,Blaze::TdfString,1,1,0,0,Blaze::TdfStringCompareIgnoreCase> mGameAttributes;
        };


         */
        
        [TdfMember("ATTR")]
        public SortedDictionary<string, string> mGameAttributes;
        
        [TdfMember("GID")]
        public uint mGameId;
    }
}
