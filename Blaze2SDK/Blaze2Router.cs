using Blaze.Core;
using Blaze2SDK.Components;

namespace Blaze2SDK;

public class Blaze2Router : BlazeRouter
{
    public Blaze2Router()
    {
        ConfigureServerErrors<ServerError>();
        ConfigureSdkErrors<SdkError>();
    }
}
