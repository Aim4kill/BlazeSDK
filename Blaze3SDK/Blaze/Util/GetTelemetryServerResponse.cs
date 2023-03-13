using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct GetTelemetryServerResponse
    {




        /*
        	TdfString ADRS = (const char*)37007354
	        TdfBool ANON = 0
	        TdfString DISA = (const char*)37007354
	        TdfString FILT = (const char*)37007354
	        TdfInt(unsigned int) LOC = 0
	        TdfString NOOK = (const char*)37007354
	        TdfInt(unsigned int) PORT = 0
	        TdfInt(unsigned int) SDLY = 0
	        TdfString SESS = (const char*)37007354
	        TdfString SKEY = (const char*)37007354
	        TdfInt(unsigned int) SPCT = 0
	        TdfString STIM = (const char*)37007354 
        
              Blaze::TdfMemberInfoString mAddressDef;
              Blaze::TdfMemberInfoInt mIsAnonymousDef;
              Blaze::TdfMemberInfoString mDisableDef;
              Blaze::TdfMemberInfoString mFilterDef;
              Blaze::TdfMemberInfoInt mLocaleDef;
              Blaze::TdfMemberInfoString mNoToggleOkDef;
              Blaze::TdfMemberInfoInt mPortDef;
              Blaze::TdfMemberInfoInt mSendDelayDef;
              Blaze::TdfMemberInfoString mSessionIDDef;
              Blaze::TdfMemberInfoString mKeyDef;
              Blaze::TdfMemberInfoInt mSendPercentageDef;
              Blaze::TdfMemberInfoString mUseServerTimeDef
        
          Blaze::TdfString mAddress;
          unsigned int mPort;
          Blaze::TdfString mKey;
          Blaze::TdfString mDisable;
          Blaze::TdfString mNoToggleOk;
          Blaze::TdfString mUseServerTime;
          Blaze::TdfString mFilter;
          unsigned int mSendPercentage;
          unsigned int mSendDelay;
          unsigned int mLocale;
          bool mIsAnonymous;
          Blaze::TdfString mSessionID;
        */

        [TdfMember("ADRS")]
        public string mAddress;

        [TdfMember("ANON")]
        public bool mIsAnonymous;

        [TdfMember("DISA")]
        public string mDisable;

        [TdfMember("FILT")]
        public string mFilter;

        [TdfMember("LOC")]
        public uint mLocale;

        [TdfMember("NOOK")]
        public string mNoToggleOk;

        [TdfMember("PORT")]
        public uint mPort;

        [TdfMember("SDLY")]
        public uint mSendDelay;

        [TdfMember("SESS")]
        public string mSessionID;

        [TdfMember("SKEY")]
        public string mKey;

        [TdfMember("SPCT")]
        public uint mSendPercentage;

        [TdfMember("STIM")]
        public string mUseServerTime;
    }
}
