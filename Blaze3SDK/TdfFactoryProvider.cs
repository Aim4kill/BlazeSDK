using Tdf;

namespace Blaze3SDK
{
    public static class TdfFactoryProvider
    {
        static TdfFactory _factory;

        static TdfFactoryProvider()
        {
            _factory = new TdfFactory();

            //TODO: Register all types
        }

        public static TdfFactory GetInstance() => _factory;

    }
}
