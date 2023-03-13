using System.Reflection;
using Tdf;

namespace BlazeCommon
{
    public interface IBlazeHelper
    {
        public string GetComponentName(ushort componentId);
        public string GetCommandName(ushort componentId, ushort commandId);
        public string GetNotificationName(ushort componentId, ushort commandId);
        public string GetErrorName(int fullError);
        public string GetErrorName(ushort componentId, ushort error) => GetErrorName(error << 16 | componentId);
        public string GetFullName(FireFrame frame)
        {
            string componentName = GetComponentName(frame.Component);
            string commandOrNotificationName;

            switch (frame.MsgType)
            {
                case FireFrame.MessageType.MESSAGE:
                case FireFrame.MessageType.REPLY:
                case FireFrame.MessageType.ERROR_REPLY:
                    commandOrNotificationName = GetCommandName(frame.Component, frame.Command);
                    break;
                case FireFrame.MessageType.NOTIFICATION:
                    commandOrNotificationName = GetNotificationName(frame.Component, frame.Command);
                    break;
                default:
                    commandOrNotificationName = frame.Command.ToString();
                    break;
            }

            return $"{componentName}::{commandOrNotificationName}";
        }

        public Type GetCommandRequestType(ushort componentId, ushort commandId);
        public Type GetCommandResponseType(ushort componentId, ushort commandId);
        public Type GetCommandErrorResponseType(ushort componentId, ushort commandId);
        public Type GetNotificationType(ushort componentId, ushort commandId);
        public Type GetNullType();
        public Type GetProtoFirePacketDataType(ProtoFirePacket packet)
        {
            return packet.Frame.MsgType switch
            {
                FireFrame.MessageType.MESSAGE => GetCommandRequestType(packet.Frame.Component, packet.Frame.Command),
                FireFrame.MessageType.REPLY => GetCommandResponseType(packet.Frame.Component, packet.Frame.Command),
                FireFrame.MessageType.NOTIFICATION => GetNotificationType(packet.Frame.Component, packet.Frame.Command),
                FireFrame.MessageType.ERROR_REPLY => GetCommandErrorResponseType(packet.Frame.Component, packet.Frame.Command),
                _ => GetNullType()
            };
        }

        static MethodInfo decodeMethod = typeof(TdfDecoder).GetMethod(nameof(TdfDecoder.Decode), new Type[] { typeof(Stream)})!;
        public IBlazePacket Decode(ProtoFirePacket packet, TdfDecoder decoder)
        {
            Type packetDataType = GetProtoFirePacketDataType(packet);
            Type blzPacketType = typeof(BlazePacket<>).MakeGenericType(packetDataType);
            object blzPacketObj = decodeMethod.MakeGenericMethod(packetDataType).Invoke(decoder, new object[] { packet.GetDataStream() } )!;
            return (IBlazePacket)Activator.CreateInstance(blzPacketType, packet.Frame, blzPacketObj)!;
        }
    }
}
