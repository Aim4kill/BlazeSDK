namespace BlazeCommon
{
    public class BlazeRpcContext
    {
        public BlazeServerConnection ConnectionInfo { get; }
        public ProtoFireConnection Connection { get => ConnectionInfo.ProtoFireConnection; }
        public object State { get => ConnectionInfo.State; set => ConnectionInfo.State = value; }
        public int ErrorCode { get; }
        public uint MsgNum { get; }
        public byte UserIndex { get; }
        public ulong Context { get; }

        internal BlazeRpcContext(BlazeServerConnection connectionInfo, int errorCode, uint msgNum, byte userIndex, ulong context)
        {
            ConnectionInfo = connectionInfo;
            ErrorCode = errorCode;
            MsgNum = msgNum;
            UserIndex = userIndex;
            Context = context;
        }

        public static implicit operator BlazeServerConnection(BlazeRpcContext context) => context.ConnectionInfo;
    }
}
