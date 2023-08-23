using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class MailComponentBase
    {
        public const ushort Id = 14;
        public const string Name = "MailComponent";
        
        public class Server : BlazeComponent<MailComponentCommand, MailComponentNotification, Blaze3RpcError>
        {
            public Server() : base(MailComponentBase.Id, MailComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)MailComponentCommand.updateMailSettings)]
            public virtual Task<NullStruct> UpdateMailSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MailComponentCommand.sendMailToSelf)]
            public virtual Task<NullStruct> SendMailToSelfAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MailComponentCommand.setMailOptInFlags)]
            public virtual Task<NullStruct> SetMailOptInFlagsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MailComponentCommand.setMailPref)]
            public virtual Task<NullStruct> SetMailPrefAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)MailComponentCommand.getMailSettings)]
            public virtual Task<NullStruct> GetMailSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<MailComponentCommand, MailComponentNotification, Blaze3RpcError>
        {
            public Client() : base(MailComponentBase.Id, MailComponentBase.Name)
            {
                
            }
        }
        
        public enum MailComponentCommand : ushort
        {
            updateMailSettings = 1,
            sendMailToSelf = 2,
            setMailOptInFlags = 3,
            setMailPref = 4,
            getMailSettings = 5,
        }
        
        public enum MailComponentNotification : ushort
        {
        }
        
    }
}
