using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATDF.Internal;

internal struct RestorePoint(long position, bool streamValid)
{
    internal long Position { get; } = position;
    internal bool StreamValid { get; } = streamValid;

    public static bool operator ==(RestorePoint left, RestorePoint right)
    {
        return left.Position == right.Position;
    }

    public static bool operator !=(RestorePoint left, RestorePoint right)
    {
        return left.Position != right.Position;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null)
            return false;

        // If run-time types are not exactly the same, return false.
        if (GetType() != obj.GetType())
            return false;

        RestorePoint other = (RestorePoint)obj;
        return other == this;
    }

    public override int GetHashCode()
    {
        return Position.GetHashCode();
    }
}
