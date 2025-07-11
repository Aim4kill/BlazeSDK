using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures.Records;

public abstract class CaptureRecord
{
    public abstract RecordType RecordType { get; }
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;

    internal virtual void WriteTo(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream, nameof(stream));

        StreamUtils.WriteTimestamp(stream, Timestamp);
    }

    internal virtual void ReadFrom(Stream stream)
    {
        ArgumentNullException.ThrowIfNull(stream, nameof(stream));

        Timestamp = StreamUtils.ReadTimestamp(stream);
    }
}
