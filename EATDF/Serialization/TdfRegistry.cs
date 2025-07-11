using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public class TdfRegistry : ITdfRegistry
{
    ConcurrentDictionary<uint, Tdf> _registeredTdfs = new ConcurrentDictionary<uint, Tdf>();

    public bool RegisterTdf<T>() where T : Tdf, new()
    {
        T tdf = new T();
        return RegisterTdf(tdf);
    }

    public bool RegisterTdf(Tdf tdf)
    {
        uint tdfId = tdf.GetTdfId();
        if (tdfId == 0)
            return false;

        return _registeredTdfs.TryAdd(tdfId, tdf);
    }

    public Tdf? CreateTdf(uint tdfId)
    {
        if (tdfId == 0)
            return null;

        if (_registeredTdfs.TryGetValue(tdfId, out Tdf? tdf))
            return tdf.CreateNew();

        return null;
    }

}
