using Blaze3SDK.Blaze;
using BlazeCommon;
using static Blaze3SDK.Components.RspComponent;

namespace Blaze3SDK.Components
{
    public class RspComponent : ComponentData<RspComponentCommand, RspComponentNotification, RspComponentError>
    {
        public RspComponent() : base((ushort)Component.RspComponent)
        {

        }

        public override Type GetCommandErrorResponseType(RspComponentCommand command) => command switch
        {
            RspComponentCommand.startPurchase => throw new NotImplementedException(),
            RspComponentCommand.updatePurchase => throw new NotImplementedException(),
            RspComponentCommand.finishPurchase => throw new NotImplementedException(),
            RspComponentCommand.listPurchases => throw new NotImplementedException(),
            RspComponentCommand.listServers => throw new NotImplementedException(),
            RspComponentCommand.getServerDetails => throw new NotImplementedException(),
            RspComponentCommand.restartServer => throw new NotImplementedException(),
            RspComponentCommand.updateServerBanner => throw new NotImplementedException(),
            RspComponentCommand.updateServerSettings => throw new NotImplementedException(),
            RspComponentCommand.updateServerPreset => throw new NotImplementedException(),
            RspComponentCommand.updateServerMapRotation => throw new NotImplementedException(),
            RspComponentCommand.addServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.removeServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.addServerBan => throw new NotImplementedException(),
            RspComponentCommand.removeServerBan => throw new NotImplementedException(),
            RspComponentCommand.addServerVip => throw new NotImplementedException(),
            RspComponentCommand.removeServerVip => throw new NotImplementedException(),
            RspComponentCommand.getConfig => throw new NotImplementedException(),
            RspComponentCommand.getPingSites => throw new NotImplementedException(),
            RspComponentCommand.getGameData => throw new NotImplementedException(),
            RspComponentCommand.addGameBan => throw new NotImplementedException(),
            RspComponentCommand.createServer => throw new NotImplementedException(),
            RspComponentCommand.updateServer => throw new NotImplementedException(),
            RspComponentCommand.listAllServers => throw new NotImplementedException(),
            RspComponentCommand.startMatch => throw new NotImplementedException(),
            RspComponentCommand.abortMatch => throw new NotImplementedException(),
            RspComponentCommand.endMatch => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandRequestType(RspComponentCommand command) => command switch
        {
            RspComponentCommand.startPurchase => throw new NotImplementedException(),
            RspComponentCommand.updatePurchase => throw new NotImplementedException(),
            RspComponentCommand.finishPurchase => throw new NotImplementedException(),
            RspComponentCommand.listPurchases => throw new NotImplementedException(),
            RspComponentCommand.listServers => throw new NotImplementedException(),
            RspComponentCommand.getServerDetails => throw new NotImplementedException(),
            RspComponentCommand.restartServer => throw new NotImplementedException(),
            RspComponentCommand.updateServerBanner => throw new NotImplementedException(),
            RspComponentCommand.updateServerSettings => throw new NotImplementedException(),
            RspComponentCommand.updateServerPreset => throw new NotImplementedException(),
            RspComponentCommand.updateServerMapRotation => throw new NotImplementedException(),
            RspComponentCommand.addServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.removeServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.addServerBan => throw new NotImplementedException(),
            RspComponentCommand.removeServerBan => throw new NotImplementedException(),
            RspComponentCommand.addServerVip => throw new NotImplementedException(),
            RspComponentCommand.removeServerVip => throw new NotImplementedException(),
            RspComponentCommand.getConfig => throw new NotImplementedException(),
            RspComponentCommand.getPingSites => throw new NotImplementedException(),
            RspComponentCommand.getGameData => throw new NotImplementedException(),
            RspComponentCommand.addGameBan => throw new NotImplementedException(),
            RspComponentCommand.createServer => throw new NotImplementedException(),
            RspComponentCommand.updateServer => throw new NotImplementedException(),
            RspComponentCommand.listAllServers => throw new NotImplementedException(),
            RspComponentCommand.startMatch => throw new NotImplementedException(),
            RspComponentCommand.abortMatch => throw new NotImplementedException(),
            RspComponentCommand.endMatch => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetCommandResponseType(RspComponentCommand command) => command switch
        {
            RspComponentCommand.startPurchase => throw new NotImplementedException(),
            RspComponentCommand.updatePurchase => throw new NotImplementedException(),
            RspComponentCommand.finishPurchase => throw new NotImplementedException(),
            RspComponentCommand.listPurchases => throw new NotImplementedException(),
            RspComponentCommand.listServers => throw new NotImplementedException(),
            RspComponentCommand.getServerDetails => throw new NotImplementedException(),
            RspComponentCommand.restartServer => throw new NotImplementedException(),
            RspComponentCommand.updateServerBanner => throw new NotImplementedException(),
            RspComponentCommand.updateServerSettings => throw new NotImplementedException(),
            RspComponentCommand.updateServerPreset => throw new NotImplementedException(),
            RspComponentCommand.updateServerMapRotation => throw new NotImplementedException(),
            RspComponentCommand.addServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.removeServerAdmin => throw new NotImplementedException(),
            RspComponentCommand.addServerBan => throw new NotImplementedException(),
            RspComponentCommand.removeServerBan => throw new NotImplementedException(),
            RspComponentCommand.addServerVip => throw new NotImplementedException(),
            RspComponentCommand.removeServerVip => throw new NotImplementedException(),
            RspComponentCommand.getConfig => throw new NotImplementedException(),
            RspComponentCommand.getPingSites => throw new NotImplementedException(),
            RspComponentCommand.getGameData => throw new NotImplementedException(),
            RspComponentCommand.addGameBan => throw new NotImplementedException(),
            RspComponentCommand.createServer => throw new NotImplementedException(),
            RspComponentCommand.updateServer => throw new NotImplementedException(),
            RspComponentCommand.listAllServers => throw new NotImplementedException(),
            RspComponentCommand.startMatch => throw new NotImplementedException(),
            RspComponentCommand.abortMatch => throw new NotImplementedException(),
            RspComponentCommand.endMatch => throw new NotImplementedException(),
            _ => typeof(NullStruct)
        };

        public override Type GetNotificationType(RspComponentNotification notification) => notification switch
        {
            _ => typeof(NullStruct)
        };

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

        public enum RspComponentError
        {
            RSP_ERR_NO_GAMEMANAGER = 67585,
            RSP_ERR_INVALID_USER_ID = 133121,
            RSP_ERR_INVALID_SERVER_ID = 198657,
            RSP_ERR_INVALID_CONSUMABLE_ID = 264193,
            RSP_ERR_INVALID_PURCHASE_ID = 329729,
            RSP_ERR_INVALID_PURCHASE_STATUS = 395265,
            RSP_ERR_INVALID_PURCHASE_QUANTITY = 460801,
            RSP_ERR_PURCHASE_EXISTS = 526337,
            RSP_ERR_SERVER_NOT_ACTIVATED = 591873,
            RSP_ERR_SERVER_HAS_EXPIRED = 657409,
            RSP_ERR_SERVER_NOT_EXTANDABLE = 722945,
            RSP_ERR_INVALID_PRESET_ID = 788481,
            RSP_ERR_INVALID_PING_SITE_ALIAS = 854017,
            RSP_ERR_INVALID_SERVER_NAME_PROFANITY = 919553,
            RSP_ERR_INVALID_SERVER_DESCRIPTION_PROFANITY = 985089,
            RSP_ERR_INVALID_SERVER_MESSAGE_PROFANITY = 1050625,
            RSP_ERR_INVALID_SERVER_PASSWORD_PROFANITY = 1116161,
            RSP_ERR_INVALID_SERVER_PRESET_TYPE = 1181697,
            RSP_ERR_INVALID_SERVER_PRESET_SETTINGS = 1247233,
            RSP_ERR_USER_IS_ALREADY_ADMIN = 1312769,
            RSP_ERR_USER_IS_NOT_ADMIN = 1378305,
            RSP_ERR_USER_ADMIN_MAX = 1443841,
            RSP_ERR_SERVER_ADMIN_MAX = 1509377,
            RSP_ERR_NO_VIRTUAL_GAME = 1574913,
            RSP_ERR_USER_IS_ALREADY_BANNED = 1640449,
            RSP_ERR_USER_IS_NOT_BANNED = 1705985,
            RSP_ERR_USER_CANNOT_BE_BANNED = 1771521,
            RSP_ERR_SERVER_BAN_MAX = 1837057,
            RSP_ERR_GAME_UPDATE_FAILED = 1902593,
            RSP_ERR_INVALID_GAME_ID = 1968129,
            RSP_ERR_INVALID_PERSISTED_GAME_ID = 2033665,
            RSP_ERR_INVALID_MAP_ROTATION_ID = 2099201,
            RSP_ERR_INVALID_MAP_ROTATION_MOD = 2164737,
            RSP_ERR_INVALID_MAP_ROTATION_ENTRIES = 2230273,
            RSP_ERR_INVALID_MAP_ROTATION_SETTINGS = 2295809,
            RSP_ERR_PING_SITE_CAPACITY_MAX = 2361345,
            RSP_ERR_SERVER_NOT_RESTARTABLE = 2426881,
            RSP_ERR_INVALID_BANNER_ID = 2492417,
            RSP_ERR_USER_IS_ALREADY_VIP = 2557953,
            RSP_ERR_USER_IS_NOT_VIP = 2623489,
            RSP_ERR_SERVER_VIP_MAX = 2689025,
            RSP_ERR_INVALID_EXPIRATION_DATE = 2754561,
            RSP_ERR_INVALID_SLAVE_SESSION_ID = 2820097,
            RSP_ERR_USER_OWNER_MAX = 2885633,
            RSP_ERR_INVALID_SERVER_NAME = 2951169,
            RSP_ERR_INVALID_PRESET_FOR_RANKED_SERVER = 3016705,
            RSP_ERR_NO_PASSWORD_FOR_PRIVATE_SERVER = 3082241,
            RSP_ERR_MATCH_ALREADY_RUNNING = 3147777,
            RSP_ERR_MATCH_NOT_RUNNING = 3213313,
            RSP_ERR_MATCH_EXPIRATION_DATE_PASSED = 3278849,
            RSP_ERR_MATCH_EMPTY_ROSTER = 3344385,
            RSP_ERR_MATCH_ROSTER_TOO_BIG = 3409921,
            RSP_ERR_INVALID_MATCH_ID = 3475457,
            RSP_ERR_WRONG_MATCH_ID = 3540993,
            RSP_ERR_INVALID_SERVER_PRESET_NAME_PROFANITY = 3606529,
            RSP_ERR_INVALID_MAP_ROTATION_NAME_PROFANITY = 3672065,
            RSP_ERR_INVALID_GAME_STATE_ACTION = 3737601,
            RSP_ERR_GAME_PERMISSION_DENIED = 3803137,
            RSP_ERR_INVALID_ACTIVE_PRESET_FOR_RANKED_SERVER = 3868673,
            RSP_ERR_SERVER_RANKED = 3934209,
            RSP_ERR_MATCH_RUNNING = 3999745,
        }

    }
}
