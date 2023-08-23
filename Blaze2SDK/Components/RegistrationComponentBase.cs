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
        }
        
        public class Client : BlazeComponent<RegistrationComponentCommand, RegistrationComponentNotification, Blaze2RpcError>
        {
            public Client() : base(RegistrationComponentBase.Id, RegistrationComponentBase.Name)
            {
                
            }
        }
        
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
