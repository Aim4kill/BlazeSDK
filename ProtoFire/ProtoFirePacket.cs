using ProtoFire.Frames;

namespace ProtoFire;

public class ProtoFirePacket
{
    public IFireFrame Frame { get; set; }
    public byte[] Data { get; set; }

    public ProtoFirePacket(IFireFrame frame, byte[] data)
    {
        Frame = frame;
        Data = data;
    }

    public MemoryStream GetDataStream()
    {
        return new MemoryStream(Data);
    }

    public static ProtoFirePacket? ReadFrom<TFrame>(Stream stream) where TFrame : IFireFrame, new()
    {
        try
        {
            TFrame frame = new TFrame();
            frame.Initialize(stream);

            // Reading the data
            byte[] data = new byte[frame.Size];

            if (frame.Size != 0)
                stream.ReadExactly(data, 0, (int)frame.Size);

            return new ProtoFirePacket(frame, data);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public void WriteTo(Stream stream)
    {
        Frame.Size = (uint)Data.Length;
        Frame.WriteTo(stream);
        if (Data.Length != 0)
            stream.Write(Data, 0, Data.Length);
    }

    public static async Task<ProtoFirePacket?> ReadFromAsync<TFrame>(Stream stream) where TFrame : IFireFrame, new()
    {
        try
        {
            TFrame frame = new TFrame();
            await frame.InitializeAsync(stream).ConfigureAwait(false);

            // Reading the data
            byte[] data = new byte[frame.Size];

            if (frame.Size != 0)
                await stream.ReadExactlyAsync(data, 0, (int)frame.Size).ConfigureAwait(false);

            return new ProtoFirePacket(frame, data);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public async Task WriteToAsync(Stream stream)
    {
        Frame.Size = (uint)Data.Length;
        await Frame.WriteToAsync(stream).ConfigureAwait(false);
        if (Data.Length != 0)
            await stream.WriteAsync(Data, 0, Data.Length).ConfigureAwait(false);
    }
}
