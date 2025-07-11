using EATDF;
using EATDF.Types;
using ProtoFire.Frames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core;

public class BlazePacket
{
    public Tdf? Data { get; set; }
    public required IFireFrame Frame { get; init; }
}
