using NLog;

namespace BlazeCommon
{
    internal static class Utils
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static void LogPacket(IBlazeComponent? component, IBlazePacket packet, bool inbound)
        {
            if (component == null)
            {
                _logger.Warn(packet.Frame.ToString(inbound));
                return;
            }

            if (_logger.IsDebugEnabled)
                _logger.Debug(packet.ToString(component, inbound));
            else
                _logger.Info(packet.Frame.ToString(component, inbound));
        }

    }
}
