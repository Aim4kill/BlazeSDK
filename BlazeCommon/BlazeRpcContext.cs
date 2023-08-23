namespace BlazeCommon
{
    public class BlazeRpcContext
    {
        public ProtoFireConnection Connection { get; }

        //TODO: Add more properties

        public BlazeRpcContext(ProtoFireConnection connection)
        {
            Connection = connection;
        }
    }
}
