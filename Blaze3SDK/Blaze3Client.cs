using BlazeCommon;
using Tdf;
using static Blaze3SDK.Components.AssociationListsComponent;
using static Blaze3SDK.Components.AuthenticationComponent;
using static Blaze3SDK.Components.CensusDataComponent;
using static Blaze3SDK.Components.ClubsComponent;
using static Blaze3SDK.Components.CommerceInfoComponent;
using static Blaze3SDK.Components.DynamicInetFilterComponent;
using static Blaze3SDK.Components.ExampleComponent;
using static Blaze3SDK.Components.GameManager;
using static Blaze3SDK.Components.GameReportingComponent;
using static Blaze3SDK.Components.GameReportingLegacyComponent;
using static Blaze3SDK.Components.GpsContentControllerComponent;
using static Blaze3SDK.Components.LeagueComponent;
using static Blaze3SDK.Components.LockerComponent;
using static Blaze3SDK.Components.MailComponent;
using static Blaze3SDK.Components.MessagingComponent;
using static Blaze3SDK.Components.PlaygroupsComponent;
using static Blaze3SDK.Components.RedirectorComponent;
using static Blaze3SDK.Components.RoomsComponent;
using static Blaze3SDK.Components.RspComponent;
using static Blaze3SDK.Components.StatsComponent;
using static Blaze3SDK.Components.TournamentsComponent;
using static Blaze3SDK.Components.UserSessions;
using static Blaze3SDK.Components.UtilComponent;

namespace Blaze3SDK
{
    public abstract class Blaze3Client : ProtoFireClient
    {
        static TdfEncoder _encoder;
        static TdfDecoder _decoder;
        static Blaze3Helper _helper;

        static Blaze3Client()
        {
            TdfFactory factory = TdfFactoryProvider.GetInstance();
            _encoder = factory.CreateEncoder(true);
            _decoder = factory.CreateDecoder(true);
            _helper = new Blaze3Helper();
        }

        public Blaze3Client(ProtoFireConnection connection) : base(connection, _helper, _encoder, _decoder)
        {


        }

        #region Extra

        #region SendRequestAsync
        public Task<IBlazePacket> SendRequestAsync<Req>(Component component, ushort command, Req request) where Req : struct => SendRequestAsync((ushort)component, command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(AuthenticationComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.AuthenticationComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(ExampleComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.ExampleComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(GameManagerCommand command, Req request) where Req : struct => SendRequestAsync(Component.GameManager, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(RedirectorComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.RedirectorComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(PlaygroupsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.PlaygroupsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(StatsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.StatsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(UtilComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.UtilComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(CensusDataComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.CensusDataComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(ClubsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.ClubsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(GameReportingLegacyComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.GameReportingLegacyComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(LeagueComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.LeagueComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(MailComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.MailComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(MessagingComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.MessagingComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(LockerComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.LockerComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(RoomsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.RoomsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(TournamentsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.TournamentsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(CommerceInfoComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.CommerceInfoComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(AssociationListsComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.AssociationListsComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(GpsContentControllerComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.GpsContentControllerComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(GameReportingComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.GameReportingComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(DynamicInetFilterComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.DynamicInetFilterComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(RspComponentCommand command, Req request) where Req : struct => SendRequestAsync(Component.RspComponent, (ushort)command, request);
        public Task<IBlazePacket> SendRequestAsync<Req>(UserSessionsCommand command, Req request) where Req : struct => SendRequestAsync(Component.UserSessions, (ushort)command, request);


        public Task<Resp> SendRequestAsync<Req, Resp>(Component component, ushort command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>((ushort)component, command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(AuthenticationComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.AuthenticationComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(ExampleComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.ExampleComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(GameManagerCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.GameManager, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(RedirectorComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.RedirectorComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(PlaygroupsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.PlaygroupsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(StatsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.StatsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(UtilComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.UtilComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(CensusDataComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.CensusDataComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(ClubsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.ClubsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(GameReportingLegacyComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.GameReportingLegacyComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(LeagueComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.LeagueComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(MailComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.MailComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(MessagingComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.MessagingComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(LockerComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.LockerComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(RoomsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.RoomsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(TournamentsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.TournamentsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(CommerceInfoComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.CommerceInfoComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(AssociationListsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.AssociationListsComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(GpsContentControllerComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.GpsContentControllerComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(GameReportingComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.GameReportingComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(DynamicInetFilterComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.DynamicInetFilterComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(RspComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.RspComponent, (ushort)command, request);
        public Task<Resp> SendRequestAsync<Req, Resp>(UserSessionsCommand command, Req request) where Req : struct where Resp : struct => SendRequestAsync<Req, Resp>(Component.UserSessions, (ushort)command, request);

        #endregion

        #region SendRequest
        public IBlazePacket SendRequest<Req>(Component component, ushort command, Req request) where Req : struct => SendRequest((ushort)component, command, request);
        public IBlazePacket SendRequest<Req>(AuthenticationComponentCommand command, Req request) where Req : struct => SendRequest(Component.AuthenticationComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(ExampleComponentCommand command, Req request) where Req : struct => SendRequest(Component.ExampleComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(GameManagerCommand command, Req request) where Req : struct => SendRequest(Component.GameManager, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(RedirectorComponentCommand command, Req request) where Req : struct => SendRequest(Component.RedirectorComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(PlaygroupsComponentCommand command, Req request) where Req : struct => SendRequest(Component.PlaygroupsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(StatsComponentCommand command, Req request) where Req : struct => SendRequest(Component.StatsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(UtilComponentCommand command, Req request) where Req : struct => SendRequest(Component.UtilComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(CensusDataComponentCommand command, Req request) where Req : struct => SendRequest(Component.CensusDataComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(ClubsComponentCommand command, Req request) where Req : struct => SendRequest(Component.ClubsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(GameReportingLegacyComponentCommand command, Req request) where Req : struct => SendRequest(Component.GameReportingLegacyComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(LeagueComponentCommand command, Req request) where Req : struct => SendRequest(Component.LeagueComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(MailComponentCommand command, Req request) where Req : struct => SendRequest(Component.MailComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(MessagingComponentCommand command, Req request) where Req : struct => SendRequest(Component.MessagingComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(LockerComponentCommand command, Req request) where Req : struct => SendRequest(Component.LockerComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(RoomsComponentCommand command, Req request) where Req : struct => SendRequest(Component.RoomsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(TournamentsComponentCommand command, Req request) where Req : struct => SendRequest(Component.TournamentsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(CommerceInfoComponentCommand command, Req request) where Req : struct => SendRequest(Component.CommerceInfoComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(AssociationListsComponentCommand command, Req request) where Req : struct => SendRequest(Component.AssociationListsComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(GpsContentControllerComponentCommand command, Req request) where Req : struct => SendRequest(Component.GpsContentControllerComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(GameReportingComponentCommand command, Req request) where Req : struct => SendRequest(Component.GameReportingComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(DynamicInetFilterComponentCommand command, Req request) where Req : struct => SendRequest(Component.DynamicInetFilterComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(RspComponentCommand command, Req request) where Req : struct => SendRequest(Component.RspComponent, (ushort)command, request);
        public IBlazePacket SendRequest<Req>(UserSessionsCommand command, Req request) where Req : struct => SendRequest(Component.UserSessions, (ushort)command, request);

        public Resp SendRequest<Req, Resp>(Component component, ushort command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>((ushort)component, command, request);
        public Resp SendRequest<Req, Resp>(AuthenticationComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.AuthenticationComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(ExampleComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.ExampleComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(GameManagerCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.GameManager, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(RedirectorComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.RedirectorComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(PlaygroupsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.PlaygroupsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(StatsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.StatsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(UtilComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.UtilComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(CensusDataComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.CensusDataComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(ClubsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.ClubsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(GameReportingLegacyComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.GameReportingLegacyComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(LeagueComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.LeagueComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(MailComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.MailComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(MessagingComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.MessagingComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(LockerComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.LockerComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(RoomsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.RoomsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(TournamentsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.TournamentsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(CommerceInfoComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.CommerceInfoComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(AssociationListsComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.AssociationListsComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(GpsContentControllerComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.GpsContentControllerComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(GameReportingComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.GameReportingComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(DynamicInetFilterComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.DynamicInetFilterComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(RspComponentCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.RspComponent, (ushort)command, request);
        public Resp SendRequest<Req, Resp>(UserSessionsCommand command, Req request) where Req : struct where Resp : struct => SendRequest<Req, Resp>(Component.UserSessions, (ushort)command, request);
        #endregion

        #endregion

    }
}
