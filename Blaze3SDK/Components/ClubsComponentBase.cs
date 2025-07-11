using Blaze.Core;
using Blaze3SDK.Blaze.Clubs;
using EATDF;
using EATDF.Types;

namespace Blaze3SDK.Components;

public static class ClubsComponentBase
{
    public const ushort Id = 11;
    public const string Name = "ClubsComponent";
    
    public enum Error : ushort {
        CLUBS_ERR_INVALID_ARGUMENT = 1002,
        CLUBS_ERR_MAX_CLUBS = 1003,
        CLUBS_ERR_CLUB_NAME_IN_USE = 1004,
        CLUBS_ERR_PROFANITY_FILTER = 1005,
        CLUBS_ERR_NO_PRIVILEGE = 1007,
        CLUBS_ERR_INVALID_USER_ID = 1008,
        CLUBS_ERR_INVALID_CLUB_ID = 1009,
        CLUBS_ERR_TOO_MANY_ITEMS_PER_FETCH_REQUESTED = 1010,
        CLUBS_ERR_INVALID_CLUBNAME_SIZE = 1011,
        CLUBS_ERR_INVALID_NON_UNIQUE_NAME_SIZE = 1012,
        CLUBS_ERR_INVALID_DOMAIN_ID = 1013,
        CLUBS_ERR_INVALID_MAX_COUNT = 1101,
        CLUBS_ERR_INVALID_OFFSET = 1102,
        CLUBS_ERR_INVALID_CLUBNAME_EMPTY = 1201,
        CLUBS_ERR_INVALID_CLUBNAME_ILLEGAL = 1202,
        CLUBS_ERR_INVALID_CLUBNAME_PROFANITY = 1203,
        CLUBS_ERR_INVALID_NON_UNIQUE_NAME_EMPTY = 1204,
        CLUBS_ERR_USER_NOT_MEMBER = 1301,
        CLUBS_ERR_LAST_GM_CANNOT_LEAVE = 1302,
        CLUBS_ERR_CANNOT_KICK_OWNER = 1303,
        CLUBS_ERR_ALREADY_GM = 1304,
        CLUBS_ERR_MAX_INVITES_SENT = 1305,
        CLUBS_ERR_MAX_INVITES_RECEIVED = 1306,
        CLUBS_ERR_MAX_PETITIONS_SENT = 1307,
        CLUBS_ERR_MAX_PETITIONS_RECEIVED = 1308,
        CLUBS_ERR_MAX_MESSAGES_SENT = 1309,
        CLUBS_ERR_MAX_MESSAGES_RECEIVED = 1310,
        CLUBS_ERR_CLUB_FULL = 1311,
        CLUBS_ERR_TOO_MANY_GMS = 1312,
        CLUBS_ERR_INVITATION_ALREADY_SENT = 1313,
        CLUBS_ERR_DEMOTE_MEMBER = 1350,
        CLUBS_ERR_DEMOTE_OWNER = 1351,
        CLUBS_ERR_DEMOTE_LAST_GM = 1352,
        CLUBS_ERR_TRANSFER_OWNERSHIP_TO_OWNER = 1361,
        CLUBS_ERR_ALREADY_MEMBER = 1401,
        CLUBS_ERR_PETITION_DISABLED = 1402,
        CLUBS_ERR_PETITION_ALREADY_SENT = 1403,
        CLUBS_ERR_JOIN_DISABLED = 1404,
        CLUBS_ERR_MISSING_NEWS_TYPE_FILTER = 1501,
        CLUBS_ERR_TOO_MANY_PARAMETERS = 1502,
        CLUBS_ERR_NEWS_TEXT_OR_STRINGID_MUST_BE_EMPTY = 1503,
        CLUBS_ERR_ASSOCIATE_CLUB_ID_MUST_BE_ZERO = 1504,
        CLUBS_ERR_NEWS_ITEM_NOT_FOUND = 1505,
        CLUBS_ERR_DUPLICATE_RIVALS = 1601,
        CLUBS_ERR_USER_BANNED = 1701,
        CLUBS_ERR_INVALID_TAG_TEXT_EMPTY = 1801,
        CLUBS_ERR_INVALID_TAG_TEXT_SIZE = 1802,
        CLUBS_ERR_TAG_TEXT_NOT_FOUND = 1803,
        CLUBS_ERR_WRONG_PASSWORD = 1901,
        CLUBS_ERR_INVALID_PASSWORD_PROFANITY = 1902,
    }
    
    public enum ClubsComponentCommand : ushort
    {
        createClub = 1100,
        getClubs = 1200,
        findClubs = 1300,
        findClubs2 = 1310,
        removeMember = 1400,
        sendInvitation = 1500,
        getInvitations = 1600,
        revokeInvitation = 1700,
        acceptInvitation = 1800,
        declineInvitation = 1900,
        getMembers = 2000,
        promoteToGM = 2100,
        demoteToMember = 2150,
        updateClubSettings = 2200,
        postNews = 2300,
        getNews = 2400,
        setNewsItemHidden = 2450,
        setMetadata = 2500,
        setMetadata2 = 2510,
        getClubsComponentSettings = 2600,
        transferOwnership = 2650,
        getClubMembershipForUsers = 2700,
        sendPetition = 2800,
        getPetitions = 2900,
        acceptPetition = 3000,
        declinePetition = 3100,
        revokePetition = 3200,
        joinClub = 3300,
        getClubRecordbook = 3400,
        resetClubRecords = 3410,
        updateMemberOnlineStatus = 3500,
        getClubAwards = 3600,
        updateMemberMetadata = 3700,
        findClubsAsync = 3800,
        findClubs2Async = 3810,
        listRivals = 3900,
        getClubTickerMessages = 4000,
        setClubTickerMessagesSubscription = 4100,
        changeClubStrings = 4200,
        countMessages = 4300,
        getMembersAsync = 4400,
        getClubBans = 4500,
        getUserBans = 4600,
        banMember = 4700,
        unbanMember = 4800,
        GetClubsComponentInfo = 4900,
        disbandClub = 5000,
        getNewsForClubs = 5100,
        getPetitionsForClubs = 5200,
    }
    
    public enum ClubsComponentNotification : ushort
    {
        FindClubsAsyncNotification = 0,
        NewClubTickerMessageNotification = 1,
        GetMembersAsyncNotification = 2,
    }
    
    public class Server : BlazeComponent {
        public override ushort Id => ClubsComponentBase.Id;
        public override string Name => ClubsComponentBase.Name;
        
        public virtual bool IsCommandSupported(ClubsComponentCommand command) => false;
        
        public class ClubsException : BlazeRpcException
        {
            public ClubsException(Error error) : base((ushort)error, null) { }
            public ClubsException(ServerError error) : base(error.WithErrorPrefix(), null) { }
            public ClubsException(Error error, Tdf? errorResponse) : base((ushort)error, errorResponse) { }
            public ClubsException(ServerError error, Tdf? errorResponse) : base(error.WithErrorPrefix(), errorResponse) { }
            public ClubsException(Error error, Tdf? errorResponse, string? message) : base((ushort)error, errorResponse, message) { }
            public ClubsException(ServerError error, Tdf? errorResponse, string? message) : base(error.WithErrorPrefix(), errorResponse, message) { }
            public ClubsException(Error error, Tdf? errorResponse, string? message, Exception? innerException) : base((ushort)error, errorResponse, message, innerException) { }
            public ClubsException(ServerError error, Tdf? errorResponse, string? message, Exception? innerException) : base(error.WithErrorPrefix(), errorResponse, message, innerException) { }
        }
        
        public Server()
        {
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.createClub,
                Name = "createClub",
                IsSupported = IsCommandSupported(ClubsComponentCommand.createClub),
                Func = async (req, ctx) => await CreateClubAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubs,
                Name = "getClubs",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubs),
                Func = async (req, ctx) => await GetClubsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.findClubs,
                Name = "findClubs",
                IsSupported = IsCommandSupported(ClubsComponentCommand.findClubs),
                Func = async (req, ctx) => await FindClubsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.findClubs2,
                Name = "findClubs2",
                IsSupported = IsCommandSupported(ClubsComponentCommand.findClubs2),
                Func = async (req, ctx) => await FindClubs2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.removeMember,
                Name = "removeMember",
                IsSupported = IsCommandSupported(ClubsComponentCommand.removeMember),
                Func = async (req, ctx) => await RemoveMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.sendInvitation,
                Name = "sendInvitation",
                IsSupported = IsCommandSupported(ClubsComponentCommand.sendInvitation),
                Func = async (req, ctx) => await SendInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getInvitations,
                Name = "getInvitations",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getInvitations),
                Func = async (req, ctx) => await GetInvitationsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.revokeInvitation,
                Name = "revokeInvitation",
                IsSupported = IsCommandSupported(ClubsComponentCommand.revokeInvitation),
                Func = async (req, ctx) => await RevokeInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.acceptInvitation,
                Name = "acceptInvitation",
                IsSupported = IsCommandSupported(ClubsComponentCommand.acceptInvitation),
                Func = async (req, ctx) => await AcceptInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.declineInvitation,
                Name = "declineInvitation",
                IsSupported = IsCommandSupported(ClubsComponentCommand.declineInvitation),
                Func = async (req, ctx) => await DeclineInvitationAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getMembers,
                Name = "getMembers",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getMembers),
                Func = async (req, ctx) => await GetMembersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.promoteToGM,
                Name = "promoteToGM",
                IsSupported = IsCommandSupported(ClubsComponentCommand.promoteToGM),
                Func = async (req, ctx) => await PromoteToGMAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.demoteToMember,
                Name = "demoteToMember",
                IsSupported = IsCommandSupported(ClubsComponentCommand.demoteToMember),
                Func = async (req, ctx) => await DemoteToMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.updateClubSettings,
                Name = "updateClubSettings",
                IsSupported = IsCommandSupported(ClubsComponentCommand.updateClubSettings),
                Func = async (req, ctx) => await UpdateClubSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.postNews,
                Name = "postNews",
                IsSupported = IsCommandSupported(ClubsComponentCommand.postNews),
                Func = async (req, ctx) => await PostNewsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getNews,
                Name = "getNews",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getNews),
                Func = async (req, ctx) => await GetNewsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.setNewsItemHidden,
                Name = "setNewsItemHidden",
                IsSupported = IsCommandSupported(ClubsComponentCommand.setNewsItemHidden),
                Func = async (req, ctx) => await SetNewsItemHiddenAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.setMetadata,
                Name = "setMetadata",
                IsSupported = IsCommandSupported(ClubsComponentCommand.setMetadata),
                Func = async (req, ctx) => await SetMetadataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.setMetadata2,
                Name = "setMetadata2",
                IsSupported = IsCommandSupported(ClubsComponentCommand.setMetadata2),
                Func = async (req, ctx) => await SetMetadata2Async(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubsComponentSettings,
                Name = "getClubsComponentSettings",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubsComponentSettings),
                Func = async (req, ctx) => await GetClubsComponentSettingsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.transferOwnership,
                Name = "transferOwnership",
                IsSupported = IsCommandSupported(ClubsComponentCommand.transferOwnership),
                Func = async (req, ctx) => await TransferOwnershipAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubMembershipForUsers,
                Name = "getClubMembershipForUsers",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubMembershipForUsers),
                Func = async (req, ctx) => await GetClubMembershipForUsersAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.sendPetition,
                Name = "sendPetition",
                IsSupported = IsCommandSupported(ClubsComponentCommand.sendPetition),
                Func = async (req, ctx) => await SendPetitionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getPetitions,
                Name = "getPetitions",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getPetitions),
                Func = async (req, ctx) => await GetPetitionsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.acceptPetition,
                Name = "acceptPetition",
                IsSupported = IsCommandSupported(ClubsComponentCommand.acceptPetition),
                Func = async (req, ctx) => await AcceptPetitionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.declinePetition,
                Name = "declinePetition",
                IsSupported = IsCommandSupported(ClubsComponentCommand.declinePetition),
                Func = async (req, ctx) => await DeclinePetitionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.revokePetition,
                Name = "revokePetition",
                IsSupported = IsCommandSupported(ClubsComponentCommand.revokePetition),
                Func = async (req, ctx) => await RevokePetitionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.joinClub,
                Name = "joinClub",
                IsSupported = IsCommandSupported(ClubsComponentCommand.joinClub),
                Func = async (req, ctx) => await JoinClubAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubRecordbook,
                Name = "getClubRecordbook",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubRecordbook),
                Func = async (req, ctx) => await GetClubRecordbookAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.resetClubRecords,
                Name = "resetClubRecords",
                IsSupported = IsCommandSupported(ClubsComponentCommand.resetClubRecords),
                Func = async (req, ctx) => await ResetClubRecordsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.updateMemberOnlineStatus,
                Name = "updateMemberOnlineStatus",
                IsSupported = IsCommandSupported(ClubsComponentCommand.updateMemberOnlineStatus),
                Func = async (req, ctx) => await UpdateMemberOnlineStatusAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubAwards,
                Name = "getClubAwards",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubAwards),
                Func = async (req, ctx) => await GetClubAwardsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.updateMemberMetadata,
                Name = "updateMemberMetadata",
                IsSupported = IsCommandSupported(ClubsComponentCommand.updateMemberMetadata),
                Func = async (req, ctx) => await UpdateMemberMetadataAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.findClubsAsync,
                Name = "findClubsAsync",
                IsSupported = IsCommandSupported(ClubsComponentCommand.findClubsAsync),
                Func = async (req, ctx) => await FindClubsAsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.findClubs2Async,
                Name = "findClubs2Async",
                IsSupported = IsCommandSupported(ClubsComponentCommand.findClubs2Async),
                Func = async (req, ctx) => await FindClubs2AsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.listRivals,
                Name = "listRivals",
                IsSupported = IsCommandSupported(ClubsComponentCommand.listRivals),
                Func = async (req, ctx) => await ListRivalsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubTickerMessages,
                Name = "getClubTickerMessages",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubTickerMessages),
                Func = async (req, ctx) => await GetClubTickerMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.setClubTickerMessagesSubscription,
                Name = "setClubTickerMessagesSubscription",
                IsSupported = IsCommandSupported(ClubsComponentCommand.setClubTickerMessagesSubscription),
                Func = async (req, ctx) => await SetClubTickerMessagesSubscriptionAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.changeClubStrings,
                Name = "changeClubStrings",
                IsSupported = IsCommandSupported(ClubsComponentCommand.changeClubStrings),
                Func = async (req, ctx) => await ChangeClubStringsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.countMessages,
                Name = "countMessages",
                IsSupported = IsCommandSupported(ClubsComponentCommand.countMessages),
                Func = async (req, ctx) => await CountMessagesAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getMembersAsync,
                Name = "getMembersAsync",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getMembersAsync),
                Func = async (req, ctx) => await GetMembersAsyncAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getClubBans,
                Name = "getClubBans",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getClubBans),
                Func = async (req, ctx) => await GetClubBansAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getUserBans,
                Name = "getUserBans",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getUserBans),
                Func = async (req, ctx) => await GetUserBansAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.banMember,
                Name = "banMember",
                IsSupported = IsCommandSupported(ClubsComponentCommand.banMember),
                Func = async (req, ctx) => await BanMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.unbanMember,
                Name = "unbanMember",
                IsSupported = IsCommandSupported(ClubsComponentCommand.unbanMember),
                Func = async (req, ctx) => await UnbanMemberAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.GetClubsComponentInfo,
                Name = "GetClubsComponentInfo",
                IsSupported = IsCommandSupported(ClubsComponentCommand.GetClubsComponentInfo),
                Func = async (req, ctx) => await GetClubsComponentInfoAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.disbandClub,
                Name = "disbandClub",
                IsSupported = IsCommandSupported(ClubsComponentCommand.disbandClub),
                Func = async (req, ctx) => await DisbandClubAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getNewsForClubs,
                Name = "getNewsForClubs",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getNewsForClubs),
                Func = async (req, ctx) => await GetNewsForClubsAsync(req, ctx).ConfigureAwait(false)
            });
            
            RegisterCommand(new RpcCommandFunc<EmptyMessage, EmptyMessage, EmptyMessage>()
            {
                Id = (ushort)ClubsComponentCommand.getPetitionsForClubs,
                Name = "getPetitionsForClubs",
                IsSupported = IsCommandSupported(ClubsComponentCommand.getPetitionsForClubs),
                Func = async (req, ctx) => await GetPetitionsForClubsAsync(req, ctx).ConfigureAwait(false)
            });
            
        }
        
        public override string GetErrorName(ushort errorCode)
        {
            return ((Error)errorCode).ToString();
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::createClub</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CreateClubAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubs</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::findClubs</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindClubsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::findClubs2</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindClubs2Async(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::removeMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RemoveMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::sendInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SendInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getInvitations</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetInvitationsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::revokeInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RevokeInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::acceptInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AcceptInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::declineInvitation</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeclineInvitationAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getMembers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMembersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::promoteToGM</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PromoteToGMAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::demoteToMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DemoteToMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::updateClubSettings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateClubSettingsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::postNews</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> PostNewsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getNews</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetNewsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::setNewsItemHidden</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetNewsItemHiddenAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::setMetadata</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetMetadataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::setMetadata2</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetMetadata2Async(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubsComponentSettings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubsComponentSettingsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::transferOwnership</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> TransferOwnershipAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubMembershipForUsers</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubMembershipForUsersAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::sendPetition</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SendPetitionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getPetitions</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPetitionsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::acceptPetition</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> AcceptPetitionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::declinePetition</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DeclinePetitionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::revokePetition</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> RevokePetitionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::joinClub</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> JoinClubAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubRecordbook</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubRecordbookAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::resetClubRecords</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ResetClubRecordsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::updateMemberOnlineStatus</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMemberOnlineStatusAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubAwards</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubAwardsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::updateMemberMetadata</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UpdateMemberMetadataAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::findClubsAsync</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindClubsAsyncAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::findClubs2Async</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> FindClubs2AsyncAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::listRivals</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ListRivalsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubTickerMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubTickerMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::setClubTickerMessagesSubscription</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> SetClubTickerMessagesSubscriptionAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::changeClubStrings</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> ChangeClubStringsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::countMessages</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> CountMessagesAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getMembersAsync</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetMembersAsyncAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getClubBans</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubBansAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getUserBans</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetUserBansAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::banMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> BanMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::unbanMember</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> UnbanMemberAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::GetClubsComponentInfo</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetClubsComponentInfoAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::disbandClub</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> DisbandClubAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getNewsForClubs</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetNewsForClubsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// This method is called when server receives a <b>ClubsComponent::getPetitionsForClubs</b> command.<br/>
        /// Request type: <see cref="EmptyMessage"/><br/>
        /// Response type: <see cref="EmptyMessage"/><br/>
        /// </summary>
        public virtual Task<EmptyMessage> GetPetitionsForClubsAsync(EmptyMessage request, BlazeRpcContext context)
        {
            throw new ClubsException(ServerError.ERR_COMMAND_NOT_FOUND);
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>ClubsComponent::FindClubsAsyncNotification</b> notification.<br/>
        /// Notification type: <see cref="FindClubsAsyncResult"/><br/>
        /// </summary>
        public static Task NotifyFindClubsAsyncNotificationAsync(BlazeRpcConnection connection, FindClubsAsyncResult notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = ClubsComponentBase.Id;
                frame.Command = (ushort)ClubsComponentNotification.FindClubsAsyncNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>ClubsComponent::NewClubTickerMessageNotification</b> notification.<br/>
        /// Notification type: <see cref="ClubTickerMessage"/><br/>
        /// </summary>
        public static Task NotifyNewClubTickerMessageNotificationAsync(BlazeRpcConnection connection, ClubTickerMessage notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = ClubsComponentBase.Id;
                frame.Command = (ushort)ClubsComponentNotification.NewClubTickerMessageNotification;
                frame.MessageType = ProtoFire.Frames.MessageType.Notification;
                packet.Data = notification;
            };
            
            if(sendNow)
                return connection.SendAsync(configurer);
            
            connection.EnqequeSend(configurer);
            return Task.CompletedTask;
        }
        
        /// <summary>
        /// Call this method when you want to send to client a <b>ClubsComponent::GetMembersAsyncNotification</b> notification.<br/>
        /// Notification type: <see cref="GetMembersAsyncResult"/><br/>
        /// </summary>
        public static Task NotifyGetMembersAsyncNotificationAsync(BlazeRpcConnection connection, GetMembersAsyncResult notification, bool sendNow = false)
        {
            Action<BlazePacket> configurer = (packet) =>
            {
                ProtoFire.Frames.IFireFrame frame = packet.Frame;
                frame.Component = ClubsComponentBase.Id;
                frame.Command = (ushort)ClubsComponentNotification.GetMembersAsyncNotification;
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

