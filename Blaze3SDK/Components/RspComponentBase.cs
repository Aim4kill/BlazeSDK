using Blaze3SDK.Blaze.Rsp;
using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class RspComponentBase
    {
        public const ushort Id = 2049;
        public const string Name = "RspComponent";
        
        public class Server : BlazeComponent<RspComponentCommand, RspComponentNotification, Blaze3RpcError>
        {
            public Server() : base(RspComponentBase.Id, RspComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)RspComponentCommand.startPurchase)]
            public virtual Task<NullStruct> StartPurchaseAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updatePurchase)]
            public virtual Task<NullStruct> UpdatePurchaseAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.finishPurchase)]
            public virtual Task<NullStruct> FinishPurchaseAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.listPurchases)]
            public virtual Task<NullStruct> ListPurchasesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.listServers)]
            public virtual Task<NullStruct> ListServersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.getServerDetails)]
            public virtual Task<NullStruct> GetServerDetailsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.restartServer)]
            public virtual Task<NullStruct> RestartServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updateServerBanner)]
            public virtual Task<NullStruct> UpdateServerBannerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updateServerSettings)]
            public virtual Task<NullStruct> UpdateServerSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updateServerPreset)]
            public virtual Task<NullStruct> UpdateServerPresetAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updateServerMapRotation)]
            public virtual Task<NullStruct> UpdateServerMapRotationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.addServerAdmin)]
            public virtual Task<NullStruct> AddServerAdminAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.removeServerAdmin)]
            public virtual Task<NullStruct> RemoveServerAdminAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.addServerBan)]
            public virtual Task<NullStruct> AddServerBanAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.removeServerBan)]
            public virtual Task<NullStruct> RemoveServerBanAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.addServerVip)]
            public virtual Task<NullStruct> AddServerVipAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.removeServerVip)]
            public virtual Task<NullStruct> RemoveServerVipAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.getConfig)]
            public virtual Task<GetConfigResponse> GetConfigAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.getPingSites)]
            public virtual Task<NullStruct> GetPingSitesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.getGameData)]
            public virtual Task<NullStruct> GetGameDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.addGameBan)]
            public virtual Task<NullStruct> AddGameBanAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.createServer)]
            public virtual Task<NullStruct> CreateServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.updateServer)]
            public virtual Task<NullStruct> UpdateServerAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.listAllServers)]
            public virtual Task<NullStruct> ListAllServersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.startMatch)]
            public virtual Task<NullStruct> StartMatchAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.abortMatch)]
            public virtual Task<NullStruct> AbortMatchAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)RspComponentCommand.endMatch)]
            public virtual Task<NullStruct> EndMatchAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<RspComponentCommand, RspComponentNotification, Blaze3RpcError>
        {
            public Client() : base(RspComponentBase.Id, RspComponentBase.Name)
            {
                
            }
        }
        
        public enum RspComponentCommand : ushort
        {
            startPurchase = 10,
            updatePurchase = 11,
            finishPurchase = 12,
            listPurchases = 15,
            listServers = 20,
            getServerDetails = 21,
            restartServer = 23,
            updateServerBanner = 24,
            updateServerSettings = 25,
            updateServerPreset = 26,
            updateServerMapRotation = 27,
            addServerAdmin = 31,
            removeServerAdmin = 32,
            addServerBan = 33,
            removeServerBan = 34,
            addServerVip = 35,
            removeServerVip = 36,
            getConfig = 50,
            getPingSites = 51,
            getGameData = 60,
            addGameBan = 61,
            createServer = 70,
            updateServer = 71,
            listAllServers = 72,
            startMatch = 80,
            abortMatch = 81,
            endMatch = 82,
        }
        
        public enum RspComponentNotification : ushort
        {
        }
        
    }
}
