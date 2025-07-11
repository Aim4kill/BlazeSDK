using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Serialization;

public interface ITdfRegistry
{
    bool RegisterTdf(Tdf tdf);
    bool RegisterTdf<T>() where T : Tdf, new();
    Tdf? CreateTdf(uint tdfId);
}
