using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blaze.Core;

public interface IBlazeRouter
{
    IBlazeComponent? GetComponent(ushort id);
    string GetErrorName(int errorCode);
}
