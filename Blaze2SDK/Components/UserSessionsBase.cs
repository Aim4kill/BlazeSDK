using Blaze2SDK.Blaze;
using BlazeCommon;

namespace Blaze2SDK.Components
{
    public static class UserSessionsBase
    {
        public const ushort Id = 30722;
        public const string Name = "UserSessions";

        public class Server : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze2RpcError>
        {
            public Server() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {

            }

            [BlazeCommand((ushort)UserSessionsCommand.lookupUserInformation)]
            public virtual Task<NullStruct> LookupUserInformationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.lookupUsersInformation)]
            public virtual Task<NullStruct> LookupUsersInformationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.fetchExtendedData)]
            public virtual Task<NullStruct> FetchExtendedDataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.updatePingSiteLatency)]
            public virtual Task<NullStruct> UpdatePingSiteLatencyAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.updateExtendedDataAttribute)]
            public virtual Task<NullStruct> UpdateExtendedDataAttributeAsync(UpdateUserSessionAttributeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.assignUserToGroup)]
            public virtual Task<NullStruct> AssignUserToGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.removeUserFromGroup)]
            public virtual Task<NullStruct> RemoveUserFromGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.updateHardwareFlags)]
            public virtual Task<NullStruct> UpdateHardwareFlagsAsync(UpdateHardwareFlagsRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.getPermissions)]
            public virtual Task<NullStruct> GetPermissionsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.getAccessGroup)]
            public virtual Task<NullStruct> GetAccessGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.checkOnlineStatus)]
            public virtual Task<NullStruct> CheckOnlineStatusAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.lookupUser)]
            public virtual Task<UserData> LookupUserAsync(UserIdentification request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.lookupUsers)]
            public virtual Task<UserDataResponse> LookupUsersAsync(LookupUsersRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.updateNetworkInfo)]
            public virtual Task<NullStruct> UpdateNetworkInfoAsync(NetworkInfo request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.listDefaultAccessGroup)]
            public virtual Task<NullStruct> ListDefaultAccessGroupAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.listAuthorization)]
            public virtual Task<NullStruct> ListAuthorizationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.lookupUserGeoIPData)]
            public virtual Task<GeoLocationData> LookupUserGeoIPDataAsync(UserIdentification request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.overrideUserGeoIPData)]
            public virtual Task<NullStruct> OverrideUserGeoIPDataAsync(GeoLocationData request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }

            [BlazeCommand((ushort)UserSessionsCommand.setUserInfoAttribute)]
            public virtual Task<NullStruct> SetUserInfoAttributeAsync(SetUserInfoAttributeRequest request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze2RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }

        public class Client : BlazeComponent<UserSessionsCommand, UserSessionsNotification, Blaze2RpcError>
        {
            public Client() : base(UserSessionsBase.Id, UserSessionsBase.Name)
            {

            }
        }

        public enum UserSessionsCommand : ushort
        {
            lookupUserInformation = 1,
            lookupUsersInformation = 2,
            fetchExtendedData = 3,
            updatePingSiteLatency = 4,
            updateExtendedDataAttribute = 5,
            assignUserToGroup = 6,
            removeUserFromGroup = 7,
            updateHardwareFlags = 8,
            getPermissions = 9,
            getAccessGroup = 10,
            checkOnlineStatus = 11,
            lookupUser = 12,
            lookupUsers = 13,
            updateNetworkInfo = 20,
            listDefaultAccessGroup = 21,
            listAuthorization = 22,
            lookupUserGeoIPData = 23,
            overrideUserGeoIPData = 24,
            setUserInfoAttribute = 25,
        }

        public enum UserSessionsNotification : ushort
        {
            UserSessionExtendedDataUpdate = 1,
            UserAdded = 2,
            UserSessionUnsubscribed = 3,
            UserSessionDisconnected = 4,
        }

    }
}
