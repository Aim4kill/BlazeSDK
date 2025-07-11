using EATDF.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public class Heat2Serializer : TdfSerializer
{
    public override string Name => "Heat2";

    public ITdfRegistry Registry { get; }

    public Heat2Serializer(ITdfRegistry registry)
    {
        Registry = registry;
    }

    public Heat2Serializer()
    {
        Registry = new TdfRegistry();
    }

    public override bool Deserialize(Stream stream, Tdf tdf)
    {
        Heat2Decoder decoder = new Heat2Decoder(stream, Registry);
        decoder.VisitTdf(tdf);
        return decoder.StreamValid;
    }

    public override void Serialize(Stream stream, Tdf tdf)
    {
        Heat2Encoder encoder = new Heat2Encoder(stream, Registry);
        encoder.VisitTdf(tdf);
    }
}

