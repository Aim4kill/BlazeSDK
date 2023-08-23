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
        }
        
        public class Client : BlazeComponent<MailComponentCommand, MailComponentNotification, Blaze2RpcError>
        {
            public Client() : base(MailComponentBase.Id, MailComponentBase.Name)
            {
                
            }
        }
        
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
