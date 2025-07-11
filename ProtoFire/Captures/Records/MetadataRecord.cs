using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures.Records;

public class MetadataRecord : CaptureRecord
{
    public override RecordType RecordType => RecordType.Metadata;
    public Perspective Perspective { get; set; } = Perspective.Unknown;
    public string Description { get; set; } = string.Empty;
    public IPEndPoint LocalEndPoint { get; set; } = new IPEndPoint(IPAddress.Any, 0);
    public IPEndPoint RemoteEndPoint { get; set; } = new IPEndPoint(IPAddress.Any, 0);


    internal override void WriteTo(Stream stream)
    {
        base.WriteTo(stream);

        StreamUtils.WriteInt(stream, (int)Perspective);
        StreamUtils.WriteString(stream, Description);
        StreamUtils.WriteIPEndPoint(stream, LocalEndPoint);
        StreamUtils.WriteIPEndPoint(stream, RemoteEndPoint);
    }

    internal override void ReadFrom(Stream stream)
    {
        base.ReadFrom(stream);

        Perspective = (Perspective)StreamUtils.ReadInt(stream);
        Description = StreamUtils.ReadString(stream);
        LocalEndPoint = StreamUtils.ReadIPEndPoint(stream);
        RemoteEndPoint = StreamUtils.ReadIPEndPoint(stream);
    }
}
