using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public abstract class TdfSerializer : ITdfSerializer
{
    public abstract string Name { get; }

    public bool Deserialize<T>(Stream stream, out T tdf) where T : Tdf, new()
    {
        tdf = new T();
        return Deserialize(stream, tdf);
    }

    public byte[] Serialize(Tdf tdf)
    {
        using MemoryStream stream = new MemoryStream();
        Serialize(stream, tdf);
        return stream.ToArray();
    }

    public abstract bool Deserialize(Stream stream, Tdf tdf);
    public abstract void Serialize(Stream stream, Tdf tdf);
}
