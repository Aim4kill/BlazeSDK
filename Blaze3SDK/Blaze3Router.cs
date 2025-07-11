using Blaze.Core;
using Blaze3SDK.Components;

namespace Blaze3SDK;

public class Blaze3Router : BlazeRouter
{
    public Blaze3Router()
    {
        ConfigureServerErrors<ServerError>();
        ConfigureSdkErrors<SdkError>();
    }
}
