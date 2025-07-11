using Blaze.Core;
using EATDF;
using EATDF.Types;

namespace Blaze2SDK.Components;

public static class MailComponentBase
{
    public const ushort Id = 14;
    public const string Name = "MailComponent";
    
    public enum Error : ushort {
        MAIL_ERR_INVALID_OPTIN_FLAGS = 1,
        MAIL_ERR_INVALID_EMAIL_FORMAT = 2,
        MAIL_ERR_USER_NOT_FOUND_IN_DB = 3,
        MAIL_ERR_SEND_MAIL_INVALID_EMAIL = 20,
        MAIL_ERR_SEND_MAIL_INVALID_TEMPLATE = 21,
        MAIL_ERR_SEND_MAIL_MISSING_HEADER = 22,
        MAIL_ERR_SEND_MAIL_MISSING_VARIABLE_VALUE = 23,
    }
    
    public enum MailComponentCommand : ushort
    {
        updateMailSettings = 1,
        sendMailToSelf = 2,
    }
    
    public enum MailComponentNotification : ushort
    {
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => MailComponentBase.Id;
        public override string Name => MailComponentBase.Name;
        
        public virtual bool IsCommandSupported(MailComponentCommand command) => false;
        
        public class MailException : BlazeRpcException
        {
            public MailException(Error error) : base((ushort)error, null) { }
            public MailException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public MailException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public MailException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public MailException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public MailException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public MailException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public MailException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MailComponentCommand.updateMailSettings,
                Name = "updateMailSettings",
                IsSupported = IsCommandSupported(MailComponentCommand.updateMailSettings),
                Func = async (req, ctx) => await UpdateMailSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)MailComponentCommand.sendMailToSelf,
                Name = "sendMailToSelf",
                IsSupported = IsCommandSupported(MailComponentCommand.sendMailToSelf),
                Func = async (req, ctx) => await SendMailToSelfAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MailComponent::updateMailSettings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMailSettingsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MailException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>MailComponent::sendMailToSelf</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SendMailToSelfAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new MailException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
    }
    
}

