using EATDF.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public class HeatSerializer : TdfSerializer
{
    public override string Name => "Heat";

    public override bool Deserialize(Stream stream, Tdf tdf)
    {
        HeatDecoder decoder = new HeatDecoder(stream);
        decoder.VisitTdf(tdf);
        return decoder.StreamValid;
    }

    public override void Serialize(Stream stream, Tdf tdf)
    {
        HeatEncoder encoder = new HeatEncoder(stream);
        encoder.VisitTdf(tdf);
    }
}

