using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class MailComponentBase
    {
        public const ushort Id = 14;
        public const string Name = "MailComponent";
        
        public class Server : BlazeComponent<MailComponentCommand, MailComponentNotification, Blaze2RpcError>
        {
            public Server() : base(MailComponentBase.Id, MailComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)MailComponentCommand.updateMailSettings)]
            public virtual Task<NullStruct> UpdateMailSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MailComponentCommand.sendMailToSelf)]
            public virtual Task<NullStruct> SendMailToSelfAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(MailComponentCommand command) => MailComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(MailComponentCommand command) => MailComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(MailComponentCommand command) => MailComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(MailComponentNotification notification) => MailComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<MailComponentCommand, MailComponentNotification, Blaze2RpcError>
        {
            public Client() : base(MailComponentBase.Id, MailComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(MailComponentCommand command) => MailComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(MailComponentCommand command) => MailComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(MailComponentCommand command) => MailComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(MailComponentNotification notification) => MailComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => typeof(NullStruct),
            MailComponentCommand.sendMailToSelf => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => typeof(NullStruct),
            MailComponentCommand.sendMailToSelf => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(MailComponentCommand command) => command switch
        {
            MailComponentCommand.updateMailSettings => typeof(NullStruct),
            MailComponentCommand.sendMailToSelf => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(MailComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum MailComponentCommand : ushort
        {
            updateMailSettings = 1,
            sendMailToSelf = 2,
        }
        
        public enum MailComponentNotification : ushort
        {
        }
        
    }
}
