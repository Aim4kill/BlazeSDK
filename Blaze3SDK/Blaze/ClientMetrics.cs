using Tdf;

namespace Blaze3SDK.Blaze
{
    [TdfStruct]
    public struct ClientMetrics
    {
        /*
        Blaze::ClientMetrics {
	        TdfBitSet UBFL
	        TdfString UDEV = (const char*)37007354
	        TdfInt(unsigned __int16) UFLG = 0
	        TdfInt(int) ULRC = 0
	        TdfInt(unsigned __int16) UNAT = 0
	        TdfEnum USTA = 0 from (Blaze::TdfEnumMap*)44653928
	        TdfInt(unsigned int) UWAN = 0
        }
        
        struct Blaze::ClientMetrics::TdfMemberInfoDefinition
        {
          Blaze::TdfMemberInfo mBlazeFlagsDef;
          Blaze::TdfMemberInfoString mDeviceInfoDef;
          Blaze::TdfMemberInfoInt mFlagsDef;
          Blaze::TdfMemberInfoInt mLastRsltCodeDef;
          Blaze::TdfMemberInfoInt mNatTypeDef;
          Blaze::TdfMemberInfoEnum mStatusDef;
          Blaze::TdfMemberInfoInt mWanIpAddrDef;
        };

        struct __cppobj Blaze::ClientMetrics : Blaze::Tdf
        {
          int mLastRsltCode;
          unsigned int mWanIpAddr;
          unsigned __int16 mFlags;
          Blaze::BlazeUpnpFlags mBlazeFlags;
          unsigned __int16 mNatType;
          Blaze::UpnpStatus mStatus;
          Blaze::TdfString mDeviceInfo;
        };

         */

        [TdfMember("UBFL")]
        public BlazeUpnpFlags mBlazeFlags;

        [TdfMember("UDEV")]
        public string mDeviceInfo;

        [TdfMember("UFLG")]
        public ushort mFlags;

        [TdfMember("ULRC")]
        public int mLastRsltCode;

        [TdfMember("UNAT")]
        public ushort mNatType;

        [TdfMember("USTA")]
        public UpnpStatus mStatus;

        [TdfMember("UWAN")]
        public uint mWanIpAddr;
    }
}
