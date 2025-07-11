namespace ProtoFire.Frames;

public interface IFireFrame
{
    FrameType Type { get; }
    MessageType MessageType { get; set; }
    public uint MessageNum { get; set; }
    int HeaderSize { get; }
    uint Size { get; set; }
    ushort Component { get; set; }
    ushort Command { get; set; }
    ushort ErrorCode { get; set; }
    int FullErrorCode { get; }
    byte UserIndex { get; set; }
    ulong Context { get; set; }

    IFireFrame CreateResponseFrame();
    IFireFrame CreateResponseFrame(ushort errorCode);

    // Reading the frame data from the stream
    void Initialize(Stream stream);
    Task InitializeAsync(Stream stream);

    // Writing the frame to the stream
    void WriteTo(Stream stream);
    Task WriteToAsync(Stream stream);
}
