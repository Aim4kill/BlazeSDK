using Tdf;

namespace Blaze3SDK.Blaze.GameManager
{
    [TdfStruct]
    public struct DatalessSetupContext
    {
        //Blaze::GameManager::DatalessContext mSetupContext;
        //	TdfEnum DCTX = 0 from (Blaze::TdfEnumMap*)44650260

        [TdfMember("DCTX")]
        public DatalessContext mSetupContext;
    }
}
