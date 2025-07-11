using Blaze.Core;
using Blaze3SDK.Blaze.CensusData;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class CensusDataComponentBase
{
    public const ushort Id = 10;
    public const string Name = "CensusDataComponent";
    
    public enum Error : ushort {
        CENSUSDATA_ERR_PLAYER_ALREADY_SUBSCRIBED = 1,
        CENSUSDATA_ERR_PLAYER_NOT_SUBSCRIBED = 2,
    }
    
    public enum CensusDataComponentCommand : ushort
    {
        subscribeToCensusData = 1,
        unsubscribeFromCensusData = 2,
        getRegionCounts = 3,
        getLatestCensusData = 4,
    }
    
    public enum CensusDataComponentNotification : ushort
    {
        NotifyServerCensusData = 1,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => CensusDataComponentBase.Id;
        public override string Name => CensusDataComponentBase.Name;
        
        public virtual bool IsCommandSupported(CensusDataComponentCommand command) => false;
        
        public class CensusDataException : BlazeRpcException
        {
            public CensusDataException(Error error) : base((ushort)error, null) { }
            public CensusDataException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public CensusDataException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public CensusDataException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public CensusDataException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public CensusDataException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public CensusDataException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public CensusDataException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CensusDataComponentCommand.subscribeToCensusData,
                Name = "subscribeToCensusData",
                IsSupported = IsCommandSupported(CensusDataComponentCommand.subscribeToCensusData),
                Func = async (req, ctx) => await SubscribeToCensusDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CensusDataComponentCommand.unsubscribeFromCensusData,
                Name = "unsubscribeFromCensusData",
                IsSupported = IsCommandSupported(CensusDataComponentCommand.unsubscribeFromCensusData),
                Func = async (req, ctx) => await UnsubscribeFromCensusDataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CensusDataComponentCommand.getRegionCounts,
                Name = "getRegionCounts",
                IsSupported = IsCommandSupported(CensusDataComponentCommand.getRegionCounts),
                Func = async (req, ctx) => await GetRegionCountsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)CensusDataComponentCommand.getLatestCensusData,
                Name = "getLatestCensusData",
                IsSupported = IsCommandSupported(CensusDataComponentCommand.getLatestCensusData),
                Func = async (req, ctx) => await GetLatestCensusDataAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CensusDataComponent::subscribeToCensusData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SubscribeToCensusDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CensusDataException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CensusDataComponent::unsubscribeFromCensusData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnsubscribeFromCensusDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CensusDataException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CensusDataComponent::getRegionCounts</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetRegionCountsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CensusDataException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>CensusDataComponent::getLatestCensusData</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetLatestCensusDataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new CensusDataException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>CensusDataComponent::NotifyServerCensusData</b> notification.<br/>
        /// Notification type: <see cref="NotifyServerCensusData"/><br/>
        /// </summary>
        public static Task NotifyNotifyServerCensusDataAsync(BlazeRpcConnection connection, NotifyServerCensusData notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = CensusDataComponentBase.Id;
                frame.Command = (ushort)CensusDataComponentNotification.NotifyServerCensusData;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
    }
    
}

