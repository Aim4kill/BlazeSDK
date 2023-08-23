namespace BlazeComponentBaseGenerator.Data
{
    class Notification
    {
        public ushort Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Notification()
        {
            Id = 0;
            Name = string.Empty;
            Type = string.Empty;
        }
    }
}
