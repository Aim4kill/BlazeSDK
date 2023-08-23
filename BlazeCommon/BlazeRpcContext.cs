namespace BlazeCommon
{
    public class BlazeRpcContext
    {
        BlazeConnectionInfo _connectionInfo;

        public ProtoFireConnection Connection => _connectionInfo.Connection;
        public object State { get => _connectionInfo.State; set => _connectionInfo.State = value; }
        public int ErrorCode { get; }
        public uint MsgNum { get; }
        public byte UserIndex { get; }
        public ulong Context { get; }

        internal BlazeRpcContext(BlazeConnectionInfo connectionInfo, int errorCode, uint msgNum, byte userIndex, ulong context)
        {
            _connectionInfo = connectionInfo;
            ErrorCode = errorCode;
            MsgNum = msgNum;
            UserIndex = userIndex;
            Context = context;
        }
    }
}
