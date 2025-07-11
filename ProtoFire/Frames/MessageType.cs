using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoFire.Frames;

public enum MessageType
{
    Message = 0,
    Reply = 1,
    Notification = 2,
    ErrorReply = 3,
    Ping = 4,
    PingReply = 5
}
