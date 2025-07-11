using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public interface ITdfSerializer
{
    public string Name { get; }
    bool Deserialize<T>(Stream stream, out T tdf) where T : Tdf, new();
    bool Deserialize(Stream stream, Tdf tdf);
    void Serialize(Stream stream, Tdf tdf);
    byte[] Serialize(Tdf tdf);
}
