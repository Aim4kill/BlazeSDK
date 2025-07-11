using ProtoFire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Blaze.Core;

internal static class Utilities
{
    public static FrameType ToFrameType(this FrameEncoding encoding)
    {
        switch (encoding)
        {
            case FrameEncoding.Fire:
                return FrameType.FireFrame;
            case FrameEncoding.Fire2:
                return FrameType.Fire2Frame;
            default:
                throw new ArgumentException("Invalid frame encoding");
        }
    }

    public static int ToFullErrorCode(ushort error, ushort component)
    {
        if (error == 0)
            return 0;

        int fullError = error << 16;

        //check if it's a global error (server error or an sdk one)
        if ((error & 0xC000) != 0) 
            return fullError;

        //this is an component error
        return fullError | component;
    }
}
