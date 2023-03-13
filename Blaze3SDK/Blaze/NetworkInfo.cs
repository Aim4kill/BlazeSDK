using Blaze3SDK.Blaze.Util;
using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct NetworkInfo
    {
        /*
        TdfUnion ADDR
	    TdfMap NLMP
	    TdfClass NQOS

          Blaze::TdfMemberInfo mAddressDef;
          Blaze::TdfMemberInfo mPingSiteLatencyByAliasMapDef;
          Blaze::TdfMemberInfoClass mQosDataDef;

          Blaze::TdfPrimitiveMap<Blaze::TdfString,int,1,0,0,0,Blaze::TdfStringCompareIgnoreCase> mPingSiteLatencyByAliasMap;
          Blaze::Util::NetworkQosData mQosData;
          Blaze::NetworkAddress mAddress;


         */

        [TdfMember("ADDR")]
        public NetworkAddress mAddress;

        [TdfMember("NLMP")]
        public Dictionary<string, int> mPingSiteLatencyByAliasMap;

        [TdfMember("NQOS")]
        public NetworkQosData mQosData;
    }
}
