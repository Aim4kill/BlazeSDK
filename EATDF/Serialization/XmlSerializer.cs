using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public class XmlSerializer : TdfSerializer
{
    public override string Name => "Xml";

    public override bool Deserialize(Stream stream, Tdf tdf)
    {
        throw new NotImplementedException();
    }

    public override void Serialize(Stream stream, Tdf tdf)
    {
        throw new NotImplementedException();
    }
}
