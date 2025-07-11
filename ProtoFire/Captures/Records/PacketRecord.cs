using ProtoFire.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures.Records;

public class PacketRecord : CaptureRecord
{
    public override RecordType RecordType => RecordType.Packet;
    public bool Inbound { get; set; }
    public ProtoFirePacket Packet { get; set; } = null!;

    internal override void WriteTo(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(Packet, nameof(Packet));

        base.WriteTo(stream);

        StreamUtils.WriteBool(stream, Inbound);
        StreamUtils.WritePacket(stream, Packet);
    }

    internal override void ReadFrom(Stream stream)
    {
        base.ReadFrom(stream);

        Inbound = StreamUtils.ReadBool(stream);
        Packet = StreamUtils.ReadPacket(stream);
    }
}
