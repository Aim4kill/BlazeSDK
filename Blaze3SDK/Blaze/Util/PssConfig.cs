using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct PssConfig
    {
        //TdfString ADRS = (const char*)37007354
        //TdfBlob CSIG
        //TdfList OIDS
        //TdfString PJID = (const char*)37007354
        //TdfInt(unsigned int) PORT = 0
        //TdfBitSet RPRT
        //TdfInt(unsigned int) TIID = 0

        //Blaze::TdfMemberInfoString mAddressDef;
        //Blaze::TdfMemberInfo mNpCommSignatureDef;
        //Blaze::TdfMemberInfo mOfferIdsDef;
        //Blaze::TdfMemberInfoString mProjectIdDef;
        //Blaze::TdfMemberInfoInt mPortDef;
        //Blaze::TdfMemberInfo mInitialReportTypesDef;
        //Blaze::TdfMemberInfoInt mTitleIdDef;


        //Blaze::TdfString mAddress;
        //unsigned int mPort;
        //unsigned int mTitleId;
        //Blaze::TdfString mProjectId;
        //Blaze::Util::PssReportTypes mInitialReportTypes;
        //Blaze::TdfPrimitiveVector<Blaze::TdfString,1,0> mOfferIds;
        //Blaze::TdfBlob mNpCommSignature;


        [TdfMember("ADRS")]
        public string mAddress;

        [TdfMember("CSIG")]
        public byte[] mNpCommSignature;

        [TdfMember("OIDS")]
        public List<string> mOfferIds;

        [TdfMember("PJID")]
        public string mProjectId;

        [TdfMember("PORT")]
        public uint mPort;

        [TdfMember("RPRT")]
        public PssReportTypes mInitialReportTypes;

        [TdfMember("TIID")]
        public uint mTitleId;
    }
}
