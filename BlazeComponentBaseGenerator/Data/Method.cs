namespace BlazeComponentBaseGenerator.Data
{
    class Method
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string RequestType { get; set; }
        public string ResponseType { get; set; }
        public string ErrorResponseType { get; set; }

        public Method()
        {
            Id = 0;
            Name = string.Empty;
            RequestType = string.Empty;
            ResponseType = string.Empty;
            ErrorResponseType = string.Empty;
        }
    }
}
