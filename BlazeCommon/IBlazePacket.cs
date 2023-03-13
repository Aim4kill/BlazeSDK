using Tdf;

namespace BlazeCommon
{
    public interface IBlazePacket
    {
        public FireFrame Frame { get; set; }
        public string ToString(IBlazeHelper helper, bool inbound);

        public void WriteTo(Stream stream, TdfEncoder encoder);

        public Task WriteToAsync(Stream stream, TdfEncoder encoder);

        public byte[] Encode(TdfEncoder encoder);

        public ProtoFirePacket ToProtoFirePacket(TdfEncoder encoder);
        public BlazePacket<Resp> CreateResponsePacket<Resp>(Resp data, int errorCode) where Resp : struct;
        public BlazePacket<Resp> CreateResponsePacket<Resp>(int errorCode) where Resp : struct;
        public BlazePacket<Resp> CreateResponsePacket<Resp>(Resp data) where Resp : struct;
    }
}
