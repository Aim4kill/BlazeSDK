using BlazeCommon;

namespace Blaze3SDK.Components
{
    public static class ClubsComponentBase
    {
        public const ushort Id = 11;
        public const string Name = "ClubsComponent";
        
        public class Server : BlazeComponent<ClubsComponentCommand, ClubsComponentNotification, Blaze3RpcError>
        {
            public Server() : base(ClubsComponentBase.Id, ClubsComponentBase.Name)
            {
                
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.createClub)]
            public virtual Task<NullStruct> CreateClubAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubs)]
            public virtual Task<NullStruct> GetClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubs)]
            public virtual Task<NullStruct> FindClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubs2)]
            public virtual Task<NullStruct> FindClubs2Async(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.removeMember)]
            public virtual Task<NullStruct> RemoveMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.sendInvitation)]
            public virtual Task<NullStruct> SendInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getInvitations)]
            public virtual Task<NullStruct> GetInvitationsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.revokeInvitation)]
            public virtual Task<NullStruct> RevokeInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.acceptInvitation)]
            public virtual Task<NullStruct> AcceptInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.declineInvitation)]
            public virtual Task<NullStruct> DeclineInvitationAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getMembers)]
            public virtual Task<NullStruct> GetMembersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.promoteToGM)]
            public virtual Task<NullStruct> PromoteToGMAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.demoteToMember)]
            public virtual Task<NullStruct> DemoteToMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateClubSettings)]
            public virtual Task<NullStruct> UpdateClubSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.postNews)]
            public virtual Task<NullStruct> PostNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getNews)]
            public virtual Task<NullStruct> GetNewsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setNewsItemHidden)]
            public virtual Task<NullStruct> SetNewsItemHiddenAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setMetadata)]
            public virtual Task<NullStruct> SetMetadataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setMetadata2)]
            public virtual Task<NullStruct> SetMetadata2Async(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubsComponentSettings)]
            public virtual Task<NullStruct> GetClubsComponentSettingsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.transferOwnership)]
            public virtual Task<NullStruct> TransferOwnershipAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubMembershipForUsers)]
            public virtual Task<NullStruct> GetClubMembershipForUsersAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.sendPetition)]
            public virtual Task<NullStruct> SendPetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getPetitions)]
            public virtual Task<NullStruct> GetPetitionsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.acceptPetition)]
            public virtual Task<NullStruct> AcceptPetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.declinePetition)]
            public virtual Task<NullStruct> DeclinePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.revokePetition)]
            public virtual Task<NullStruct> RevokePetitionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.joinClub)]
            public virtual Task<NullStruct> JoinClubAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubRecordbook)]
            public virtual Task<NullStruct> GetClubRecordbookAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.resetClubRecords)]
            public virtual Task<NullStruct> ResetClubRecordsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateMemberOnlineStatus)]
            public virtual Task<NullStruct> UpdateMemberOnlineStatusAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubAwards)]
            public virtual Task<NullStruct> GetClubAwardsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.updateMemberMetadata)]
            public virtual Task<NullStruct> UpdateMemberMetadataAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubsAsync)]
            public virtual Task<NullStruct> FindClubsAsyncAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.findClubs2Async)]
            public virtual Task<NullStruct> FindClubs2AsyncAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.listRivals)]
            public virtual Task<NullStruct> ListRivalsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubTickerMessages)]
            public virtual Task<NullStruct> GetClubTickerMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.setClubTickerMessagesSubscription)]
            public virtual Task<NullStruct> SetClubTickerMessagesSubscriptionAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.changeClubStrings)]
            public virtual Task<NullStruct> ChangeClubStringsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.countMessages)]
            public virtual Task<NullStruct> CountMessagesAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getMembersAsync)]
            public virtual Task<NullStruct> GetMembersAsyncAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getClubBans)]
            public virtual Task<NullStruct> GetClubBansAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getUserBans)]
            public virtual Task<NullStruct> GetUserBansAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.banMember)]
            public virtual Task<NullStruct> BanMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.unbanMember)]
            public virtual Task<NullStruct> UnbanMemberAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.GetClubsComponentInfo)]
            public virtual Task<NullStruct> GetClubsComponentInfoAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.disbandClub)]
            public virtual Task<NullStruct> DisbandClubAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getNewsForClubs)]
            public virtual Task<NullStruct> GetNewsForClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
            
            [BlazeCommand((ushort)ClubsComponentCommand.getPetitionsForClubs)]
            public virtual Task<NullStruct> GetPetitionsForClubsAsync(NullStruct request, BlazeRpcContext context)
            {
                throw new BlazeRpcException(Blaze3RpcError.ERR_COMMAND_NOT_FOUND);
            }
        }
        
        public class Client : BlazeComponent<ClubsComponentCommand, ClubsComponentNotification, Blaze3RpcError>
        {
            public Client() : base(ClubsComponentBase.Id, ClubsComponentBase.Name)
            {
                
            }
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
        
    }
}
