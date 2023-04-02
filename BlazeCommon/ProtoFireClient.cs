using Tdf;

namespace BlazeCommon
{
    public abstract class ProtoFireClient : ProtoFireBasicClient
    {
        TdfEncoder _encoder;
        TdfDecoder _decoder;
        IBlazeHelper _blazeHelper;
        uint _msgNum;
        public ProtoFireClient(ProtoFireConnection connection, IBlazeHelper helper, TdfEncoder encoder, TdfDecoder decoder) : base(connection)
        {
            _encoder = encoder;
            _decoder = decoder;
            _blazeHelper = helper;
            _msgNum = 0;
        }

        public async Task<IBlazePacket> SendRequestAsync<Req>(ushort component, ushort command, Req request) where Req : struct
        {
            BlazePacket<Req> reqPacket = new BlazePacket<Req>(new FireFrame()
            {
                MsgNum = Interlocked.Increment(ref _msgNum),
                MsgType = FireFrame.MessageType.MESSAGE,
                Component = component,
                Command = command,
            }, request);
            ProtoFirePacket response = await SendRequestAsync(reqPacket.ToProtoFirePacket(_encoder)).ConfigureAwait(false);
            return _blazeHelper.Decode(response, _decoder);
        }

        public IBlazePacket SendRequest<Req>(ushort component, ushort command, Req request) where Req : struct
        {
            BlazePacket<Req> reqPacket = new BlazePacket<Req>(new FireFrame()
            {
                MsgNum = Interlocked.Increment(ref _msgNum),
                MsgType = FireFrame.MessageType.MESSAGE,
                Component = component,
                Command = command,
            }, request);
            ProtoFirePacket response = SendRequest(reqPacket.ToProtoFirePacket(_encoder));
            return _blazeHelper.Decode(response, _decoder);
        }
        public async Task<Resp> SendRequestAsync<Req, Resp>(ushort component, ushort command, Req request) where Req : struct where Resp : struct
        {
            BlazePacket<Req> reqPacket = new BlazePacket<Req>(new FireFrame()
            {
                MsgNum = Interlocked.Increment(ref _msgNum),
                MsgType = FireFrame.MessageType.MESSAGE,
                Component = component,
                Command = command,
            }, request);
            ProtoFirePacket response = await SendRequestAsync(reqPacket.ToProtoFirePacket(_encoder)).ConfigureAwait(false);
            return _decoder.Decode<Resp>(response.GetDataStream());
        }

        public Resp SendRequest<Req, Resp>(ushort component, ushort command, Req request) where Req : struct where Resp : struct
        {
            BlazePacket<Req> reqPacket = new BlazePacket<Req>(new FireFrame()
            {
                MsgNum = Interlocked.Increment(ref _msgNum),
                MsgType = FireFrame.MessageType.MESSAGE,
                Component = component,
                Command = command,
            }, request);
            ProtoFirePacket response = SendRequest(reqPacket.ToProtoFirePacket(_encoder));
            return _decoder.Decode<Resp>(response.GetDataStream());
        }

        public override void OnNonReplyPacketReceived(ProtoFirePacket request)
        {
            OnNonReplyPacketReceived(_blazeHelper.Decode(request, _decoder));
        }

        public abstract void OnNonReplyPacketReceived(IBlazePacket request);
    }
}
