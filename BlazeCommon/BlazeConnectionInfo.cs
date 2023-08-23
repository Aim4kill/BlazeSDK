namespace BlazeCommon
{
    public class BlazeConnectionInfo
    {
        public ProtoFireConnection Connection { get; }
        public object State { get; set; }

        public BlazeConnectionInfo(ProtoFireConnection connection)
        {
            Connection = connection;
            State = new object();
        }
    }
}
