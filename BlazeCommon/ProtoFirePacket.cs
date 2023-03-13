namespace BlazeCommon
{
    public class ProtoFirePacket
    {
        public FireFrame Frame { get; set; }
        public byte[] Data { get; set; }
        
        public ProtoFirePacket(FireFrame frame, byte[] data)
        {
            Frame = frame;
            Data = data;
        }

        public MemoryStream GetDataStream()
        {
            return new MemoryStream(Data, false);
        }

        public void WriteTo(Stream stream)
        {
            Frame.Size = (uint)Data.Length;
            Frame.WriteTo(stream);
            if (Data.Length != 0)
                stream.Write(Data, 0, Data.Length);
        }

        public async Task WriteToAsync(Stream stream)
        {
            Frame.Size = (uint)Data.Length;
            await Frame.WriteToAsync(stream).ConfigureAwait(false);
            if(Data.Length != 0)
                await stream.WriteAsync(Data, 0, Data.Length).ConfigureAwait(false);
        }
    }
}
