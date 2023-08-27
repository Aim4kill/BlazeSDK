using System.Collections.Generic;

namespace BlazeComponentBaseGenerator.Data
{
    class Component
    {
        public ushort Id;
        public string Name;
        public string DefaultRequestType;
        public string DefaultResponseType;
        public string DefaultErrorType;
        public string DefaultNotificationType;
        public string ErrorEnum;

        public List<Method> Methods;
        public List<Notification> Notifications;

        public Component()
        {
            Id = 0;
            Name = string.Empty;
            DefaultRequestType = "NullStruct";
            DefaultResponseType = "NullStruct";
            DefaultErrorType = "NullStruct";
            DefaultNotificationType = "NullStruct";
            ErrorEnum = string.Empty;
            Methods = new List<Method>();
            Notifications = new List<Notification>();

        }
    }
}
