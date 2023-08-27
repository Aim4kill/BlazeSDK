using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class RegistrationComponentBase
    {
        public const ushort Id = 22;
        public const string Name = "RegistrationComponent";
        
        public class Server : BlazeComponent<RegistrationComponentCommand, RegistrationComponentNotification, Blaze2RpcError>
        {
            public Server() : base(RegistrationComponentBase.Id, RegistrationComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.check)]
            public virtual Task<NullStruct> CheckAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.addrow)]
            public virtual Task<NullStruct> AddrowAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.ban)]
            public virtual Task<NullStruct> BanAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.remrow)]
            public virtual Task<NullStruct> RemrowAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.returnusers)]
            public virtual Task<NullStruct> ReturnusersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.numusers)]
            public virtual Task<NullStruct> NumusersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.updatenote)]
            public virtual Task<NullStruct> UpdatenoteAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.wipestats)]
            public virtual Task<NullStruct> WipestatsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.updateflags)]
            public virtual Task<NullStruct> UpdateflagsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RegistrationComponentCommand.getDbCredentials)]
            public virtual Task<NullStruct> GetDbCredentialsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            
            public override Type GetCommandRequestType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RegistrationComponentNotification notification) => RegistrationComponentBase.GetNotificationType(notification);
            
        }
        
        public class Client : BlazeComponent<RegistrationComponentCommand, RegistrationComponentNotification, Blaze2RpcError>
        {
            public Client() : base(RegistrationComponentBase.Id, RegistrationComponentBase.Name)
            {
                
            }
            
            public override Type GetCommandRequestType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandRequestType(command);
            public override Type GetCommandResponseType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandResponseType(command);
            public override Type GetCommandErrorResponseType(RegistrationComponentCommand command) => RegistrationComponentBase.GetCommandErrorResponseType(command);
            public override Type GetNotificationType(RegistrationComponentNotification notification) => RegistrationComponentBase.GetNotificationType(notification);
            
        }
        
        public static Type GetCommandRequestType(RegistrationComponentCommand command) => command switch
        {
            RegistrationComponentCommand.check => typeof(NullStruct),
            RegistrationComponentCommand.addrow => typeof(NullStruct),
            RegistrationComponentCommand.ban => typeof(NullStruct),
            RegistrationComponentCommand.remrow => typeof(NullStruct),
            RegistrationComponentCommand.returnusers => typeof(NullStruct),
            RegistrationComponentCommand.numusers => typeof(NullStruct),
            RegistrationComponentCommand.updatenote => typeof(NullStruct),
            RegistrationComponentCommand.wipestats => typeof(NullStruct),
            RegistrationComponentCommand.updateflags => typeof(NullStruct),
            RegistrationComponentCommand.getDbCredentials => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandResponseType(RegistrationComponentCommand command) => command switch
        {
            RegistrationComponentCommand.check => typeof(NullStruct),
            RegistrationComponentCommand.addrow => typeof(NullStruct),
            RegistrationComponentCommand.ban => typeof(NullStruct),
            RegistrationComponentCommand.remrow => typeof(NullStruct),
            RegistrationComponentCommand.returnusers => typeof(NullStruct),
            RegistrationComponentCommand.numusers => typeof(NullStruct),
            RegistrationComponentCommand.updatenote => typeof(NullStruct),
            RegistrationComponentCommand.wipestats => typeof(NullStruct),
            RegistrationComponentCommand.updateflags => typeof(NullStruct),
            RegistrationComponentCommand.getDbCredentials => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetCommandErrorResponseType(RegistrationComponentCommand command) => command switch
        {
            RegistrationComponentCommand.check => typeof(NullStruct),
            RegistrationComponentCommand.addrow => typeof(NullStruct),
            RegistrationComponentCommand.ban => typeof(NullStruct),
            RegistrationComponentCommand.remrow => typeof(NullStruct),
            RegistrationComponentCommand.returnusers => typeof(NullStruct),
            RegistrationComponentCommand.numusers => typeof(NullStruct),
            RegistrationComponentCommand.updatenote => typeof(NullStruct),
            RegistrationComponentCommand.wipestats => typeof(NullStruct),
            RegistrationComponentCommand.updateflags => typeof(NullStruct),
            RegistrationComponentCommand.getDbCredentials => typeof(NullStruct),
            _ => typeof(NullStruct)
        };
        
        public static Type GetNotificationType(RegistrationComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };
        
        public enum RegistrationComponentCommand : ushort
        {
            check = 2,
            addrow = 3,
            ban = 4,
            remrow = 5,
            returnusers = 9,
            numusers = 10,
            updatenote = 13,
            wipestats = 14,
            updateflags = 15,
            getDbCredentials = 16,
        }
        
        public enum RegistrationComponentNotification : ushort
        {
        }
        
    }
}
