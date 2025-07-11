using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Captures.Records;

public enum RecordType : byte
{
    Metadata = 0,
    Packet = 1,
}
