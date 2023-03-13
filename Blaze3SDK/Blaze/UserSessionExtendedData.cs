using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct UserSessionExtendedData
    {
        /*
          Blaze::TdfMemberInfo mAddressDef;
          Blaze::TdfMemberInfoString mBestPingSiteAliasDef;
          Blaze::TdfMemberInfo mClientAttributesDef;
          Blaze::TdfMemberInfoString mCountryDef;
          Blaze::TdfMemberInfo mClientDataDef;
          Blaze::TdfMemberInfo mDataMapDef;
          Blaze::TdfMemberInfo mHardwareFlagsDef;
          Blaze::TdfMemberInfo mLatencyListDef;
          Blaze::TdfMemberInfoClass mQosDataDef;
          Blaze::TdfMemberInfoInt64 mUserInfoAttributeDef;
          Blaze::TdfMemberInfo mBlazeObjectIdListDef;

          	TdfUnion ADDR
	        TdfString BPS = (const char*)37007354
	        TdfMap CMAP
	        TdfString CTY = (const char*)37007354
	        TODO-Blaze::VariableTdfBase CVAR
	        TdfMap DMAP
	        TdfBitSet HWFG
	        TdfList PSLM
	        TdfClass QDAT
	        TdfInt(unsigned __int64) UATT = 0
	        TdfList ULST

          Blaze::TdfPrimitiveMap<unsigned int,__int64,0,0,0,0,eastl::less<unsigned int> > mDataMap;
          Blaze::TdfPrimitiveVector<Blaze::BlazeObjectId,9,0> mBlazeObjectIdList;
          Blaze::TdfString mBestPingSiteAlias;
          Blaze::TdfPrimitiveVector<int,0,0> mLatencyList;
          Blaze::Util::NetworkQosData mQosData;
          Blaze::NetworkAddress mAddress;
          Blaze::TdfPrimitiveMap<unsigned int,int,0,0,0,0,eastl::less<unsigned int> > mClientAttributes;
          Blaze::VariableTdfBase mClientData;
          Blaze::HardwareFlags mHardwareFlags;
          Blaze::TdfString mCountry;
          unsigned __int64 mUserInfoAttribute;
         */

        [TdfMember("ADDR")]
        public NetworkAddress mAddress;

        [TdfMember("BPS")]
        public string mBestPingSiteAlias;

        [TdfMember("CMAP")]
        public SortedDictionary<uint, int> mClientAttributes;

        [TdfMember("CTY")]
        public string mCountry;

        [TdfMember("CVAR")]
        public object? mClientData;

        [TdfMember("DMAP")]
        public SortedDictionary<uint, long> mDataMap;

        [TdfMember("HWFG")]
        public HardwareFlags mHardwareFlags;

        [TdfMember("PSLM")]
        public List<int> mLatencyList;

        [TdfMember("QDAT")]
        public Util.NetworkQosData mQosData;

        [TdfMember("UATT")]
        public ulong mUserInfoAttribute;

        [TdfMember("ULST")]
        public List<BlazeObjectId> mBlazeObjectIdList;
    }
}
