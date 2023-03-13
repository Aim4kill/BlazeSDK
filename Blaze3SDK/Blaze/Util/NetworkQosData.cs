using Tdf;

namespace Blaze3SDK.Blaze.Util
{
    [TdfStruct]
    public struct NetworkQosData
    {
        /*
         *    Blaze::TdfMemberInfoInt mDownstreamBitsPerSecondDef;
              Blaze::TdfMemberInfoEnum mNatTypeDef;
              Blaze::TdfMemberInfoInt mUpstreamBitsPerSecondDef;
        
            	TdfInt(unsigned int) DBPS = 0
	            TdfEnum NATT = 0 from (Blaze::TdfEnumMap*)44653952
	            TdfInt(unsigned int) UBPS = 0

                  Blaze::Util::NatType mNatType;
                  unsigned int mUpstreamBitsPerSecond;
                  unsigned int mDownstreamBitsPerSecond;
         */

        [TdfMember("DBPS")]
        public uint mDownstreamBitsPerSecond;

        [TdfMember("NATT")]
        public NatType mNatType;

        [TdfMember("UBPS")]
        public uint mUpstreamBitsPerSecond;
    }
}
