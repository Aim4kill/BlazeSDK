using BlazeComponentBaseGenerator.Data;
using Microsoft.VisualStudio.TextTemplating.VSHost;
using Newtonsoft.Json;
using System;
using System.Text;

namespace BlazeComponentBaseGenerator
{
    internal class JsonToBlazeComponentBase : BaseCodeGeneratorWithSite
    {
        public const string Name = "BlazeComponentBaseGenerator";
        public const string Description = "Generates BlazeComponentBase classes from a JSON file.";
        public const string FileExtension = ".json";

        public override string GetDefaultExtension() => ".cs";

        byte[] StringToBytes(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        void AppendComponentServerMethods(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";

            foreach (Method method in component.Methods)
            {
                string methodName = method.Name;
                if (methodName.Length != 0)
                    methodName = char.ToUpper(methodName[0]) + methodName.Substring(1);
                methodName += "Async";

                string requestType = method.RequestType;
                if (string.IsNullOrEmpty(requestType))
                    requestType = component.DefaultRequestType;

                string responseType = method.ResponseType;
                if (string.IsNullOrEmpty(responseType))
                    responseType = component.DefaultResponseType;

                builder.AppendLine();
                builder.AppendLine($"[BlazeCommand((ushort){componentCommandName}.{method.Name})]");
                builder.AppendLine($"public virtual Task<{responseType}> {methodName}({requestType} request, BlazeRpcContext context)");
                builder.AppendLine($"{{");
                builder.AddTab();

                builder.AppendLine($"throw new BlazeRpcException({component.ErrorEnum}.ERR_COMMAND_NOT_FOUND);");

                builder.RemoveTab();
                builder.AppendLine($"}}");

            }
        }

        void AppendComponentProxyMethods(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";

            foreach (Method method in component.Methods)
            {
                string methodName = method.Name;
                if (methodName.Length != 0)
                    methodName = char.ToUpper(methodName[0]) + methodName.Substring(1);
                methodName += "Async";

                string requestType = method.RequestType;
                if (string.IsNullOrEmpty(requestType))
                    requestType = component.DefaultRequestType;

                string responseType = method.ResponseType;
                if (string.IsNullOrEmpty(responseType))
                    responseType = component.DefaultResponseType;

                string errorResponseType = method.ErrorResponseType;
                if (string.IsNullOrEmpty(errorResponseType))
                    errorResponseType = component.DefaultErrorType;

                builder.AppendLine();
                builder.AppendLine($"[BlazeCommand((ushort){componentCommandName}.{method.Name})]");
                builder.AppendLine($"public virtual Task<{responseType}> {methodName}({requestType} request, BlazeProxyContext context)");
                builder.AppendLine($"{{");
                builder.AddTab();

                builder.AppendLine($"return context.ClientConnection.SendRequestAsync<{requestType}, {responseType}, {errorResponseType}>(this, (ushort){componentCommandName}.{method.Name}, request);");

                builder.RemoveTab();
                builder.AppendLine($"}}");

            }
        }

        void AppendComponentClientMethods(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";

            foreach (Method method in component.Methods)
            {
                string methodName = method.Name;

                if (methodName.Length != 0)
                    methodName = char.ToUpper(methodName[0]) + methodName.Substring(1);

                if (methodName.EndsWith("Async"))
                    methodName += "hronously";

                string methodAsynName = methodName + "Async";

                string requestType = method.RequestType;
                if (string.IsNullOrEmpty(requestType))
                    requestType = component.DefaultRequestType;

                string responseType = method.ResponseType;
                if (string.IsNullOrEmpty(responseType))
                    responseType = component.DefaultResponseType;

                string errorResponseType = method.ErrorResponseType;
                if (string.IsNullOrEmpty(errorResponseType))
                    errorResponseType = component.DefaultErrorType;

                builder.AppendLine();

                if (requestType == "NullStruct")
                {
                    builder.AppendLine($"public {responseType} {methodName}()");
                    builder.AppendLine($"{{");
                    builder.AddTab();
                    builder.AppendLine($"return Connection.SendRequest<{requestType}, {responseType}, {errorResponseType}>(this, (ushort){componentCommandName}.{method.Name}, new NullStruct());");
                    builder.RemoveTab();
                    builder.AppendLine($"}}");

                    builder.AppendLine($"public Task<{responseType}> {methodAsynName}()");
                    builder.AppendLine($"{{");
                    builder.AddTab();
                    builder.AppendLine($"return Connection.SendRequestAsync<{requestType}, {responseType}, {errorResponseType}>(this, (ushort){componentCommandName}.{method.Name}, new NullStruct());");
                    builder.RemoveTab();
                    builder.AppendLine($"}}");
                }
                else
                {
                    builder.AppendLine($"public {responseType} {methodName}({requestType} request)");
                    builder.AppendLine($"{{");
                    builder.AddTab();
                    builder.AppendLine($"return Connection.SendRequest<{requestType}, {responseType}, {errorResponseType}>(this, (ushort){componentCommandName}.{method.Name}, request);");
                    builder.RemoveTab();
                    builder.AppendLine($"}}");

                    builder.AppendLine($"public Task<{responseType}> {methodAsynName}({requestType} request)");
                    builder.AppendLine($"{{");
                    builder.AddTab();
                    builder.AppendLine($"return Connection.SendRequestAsync<{requestType}, {responseType}, {errorResponseType}>(this, (ushort){componentCommandName}.{method.Name}, request);");
                    builder.RemoveTab();
                    builder.AppendLine($"}}");
                }


            }
        }

        void AppendComponentServerNotifications(CStringBuilder builder, Data.Component component)
        {
            string componentBaseName = $"{component.Name}Base";
            string componentNotificationName = $"{component.Name}Notification";

            foreach (Notification notification in component.Notifications)
            {
                string notificationMethodName = notification.Name;

                if (notificationMethodName.Length != 0)
                    notificationMethodName = char.ToUpper(notificationMethodName[0]) + notificationMethodName.Substring(1);

                if (!notificationMethodName.StartsWith("Notify"))
                    notificationMethodName = "Notify" + notificationMethodName;

                if (!notificationMethodName.EndsWith("Async"))
                    notificationMethodName += "Async";

                string notificationType = notification.Type;
                if (string.IsNullOrEmpty(notificationType))
                    notificationType = component.DefaultNotificationType;

                builder.AppendLine();
                builder.AppendLine($"public static Task {notificationMethodName}(BlazeServerConnection connection, {notificationType} notification, bool waitUntilFree = false)");
                builder.AppendLine($"{{");
                builder.AddTab();
                builder.AppendLine($"return connection.NotifyAsync({componentBaseName}.Id, (ushort){componentNotificationName}.{notification.Name}, notification, waitUntilFree);");
                builder.RemoveTab();
                builder.AppendLine($"}}");
            }
        }

        void AppendComponentClientNotifications(CStringBuilder builder, Data.Component component)
        {
            string componentBaseName = $"{component.Name}Base";
            string componentNotificationName = $"{component.Name}Notification";

            foreach (Notification notification in component.Notifications)
            {
                string notificationMethodName = notification.Name;
                if (notificationMethodName.Length != 0)
                    notificationMethodName = char.ToUpper(notificationMethodName[0]) + notificationMethodName.Substring(1);

                if (!notificationMethodName.StartsWith("On"))
                    notificationMethodName = "On" + notificationMethodName;

                if (!notificationMethodName.EndsWith("Async"))
                    notificationMethodName += "Async";

                string notificationType = notification.Type;
                if (string.IsNullOrEmpty(notificationType))
                    notificationType = component.DefaultNotificationType;

                builder.AppendLine();
                builder.AppendLine($"[BlazeNotification((ushort){componentNotificationName}.{notification.Name})]");

                if (notificationType != "NullStruct")
                    builder.AppendLine($"public virtual Task {notificationMethodName}({notificationType} notification)");
                else
                    builder.AppendLine($"public virtual Task {notificationMethodName}()");

                builder.AppendLine($"{{");
                builder.AddTab();

                builder.AppendLine($"_logger.Warn($\"{{GetType().FullName}}: {notificationMethodName} NOT IMPLEMENTED!\");");
                builder.AppendLine("return Task.CompletedTask;");

                builder.RemoveTab();
                builder.AppendLine($"}}");
            }
        }

        void AppendComponentProxyNotifications(CStringBuilder builder, Data.Component component)
        {
            string componentBaseName = $"{component.Name}Base";
            string componentNotificationName = $"{component.Name}Notification";

            foreach (Notification notification in component.Notifications)
            {
                string notificationMethodName = notification.Name;
                if (notificationMethodName.Length != 0)
                    notificationMethodName = char.ToUpper(notificationMethodName[0]) + notificationMethodName.Substring(1);

                if (!notificationMethodName.StartsWith("On"))
                    notificationMethodName = "On" + notificationMethodName;

                if (!notificationMethodName.EndsWith("Async"))
                    notificationMethodName += "Async";

                string notificationType = notification.Type;
                if (string.IsNullOrEmpty(notificationType))
                    notificationType = component.DefaultNotificationType;

                builder.AppendLine();
                builder.AppendLine($"[BlazeNotification((ushort){componentNotificationName}.{notification.Name})]");
                builder.AppendLine($"public virtual Task<{notificationType}> {notificationMethodName}({notificationType} notification)");


                builder.AppendLine($"{{");
                builder.AddTab();

                builder.AppendLine("return Task.FromResult(notification);");

                builder.RemoveTab();
                builder.AppendLine($"}}");
            }
        }

        void AppendComponentServerBase(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            string componentCommandNotification = $"{component.Name}Notification";

            builder.AppendLine($"public class Server : BlazeServerComponent<{componentCommandName}, {componentCommandNotification}, {component.ErrorEnum}>");
            builder.AppendLine($"{{");
            builder.AddTab();

            builder.AppendLine($"public Server() : base({component.Name}Base.Id, {component.Name}Base.Name)");
            builder.AppendLine($"{{");
            builder.AddTab();
            builder.AppendLine();
            builder.RemoveTab();
            builder.AppendLine($"}}");

            AppendComponentServerMethods(builder, component);
            builder.AppendLine();

            AppendComponentServerNotifications(builder, component);
            builder.AppendLine();


            builder.AppendLine($"public override Type GetCommandRequestType({componentCommandName} command) => {component.Name}Base.GetCommandRequestType(command);");
            builder.AppendLine($"public override Type GetCommandResponseType({componentCommandName} command) => {component.Name}Base.GetCommandResponseType(command);");
            builder.AppendLine($"public override Type GetCommandErrorResponseType({componentCommandName} command) => {component.Name}Base.GetCommandErrorResponseType(command);");
            builder.AppendLine($"public override Type GetNotificationType({componentCommandNotification} notification) => {component.Name}Base.GetNotificationType(notification);");
            builder.AppendLine();

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }
        void AppendComponentClientBase(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            string componentCommandNotification = $"{component.Name}Notification";

            builder.AppendLine($"public class Client : BlazeClientComponent<{componentCommandName}, {componentCommandNotification}, {component.ErrorEnum}>");
            builder.AppendLine($"{{");
            builder.AddTab();
            builder.AppendLine("BlazeClientConnection Connection { get; }");
            builder.AppendLine("private static Logger _logger = LogManager.GetCurrentClassLogger();");
            builder.AppendLine();

            builder.AppendLine($"public Client(BlazeClientConnection connection) : base({component.Name}Base.Id, {component.Name}Base.Name)");
            builder.AppendLine($"{{");
            builder.AddTab();
            builder.AppendLine("Connection = connection;");

            builder.AppendLine("if (!Connection.Config.AddComponent(this))");
            builder.AddTab();
            builder.AppendLine("throw new InvalidOperationException($\"A component with Id({Id}) has already been created for the connection.\");");
            builder.RemoveTab();

            builder.RemoveTab();
            builder.AppendLine($"}}");
            builder.AppendLine();

            AppendComponentClientMethods(builder, component);
            builder.AppendLine();

            AppendComponentClientNotifications(builder, component);
            builder.AppendLine();

            builder.AppendLine($"public override Type GetCommandRequestType({componentCommandName} command) => {component.Name}Base.GetCommandRequestType(command);");
            builder.AppendLine($"public override Type GetCommandResponseType({componentCommandName} command) => {component.Name}Base.GetCommandResponseType(command);");
            builder.AppendLine($"public override Type GetCommandErrorResponseType({componentCommandName} command) => {component.Name}Base.GetCommandErrorResponseType(command);");
            builder.AppendLine($"public override Type GetNotificationType({componentCommandNotification} notification) => {component.Name}Base.GetNotificationType(notification);");
            builder.AppendLine();

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }

        void AppendComponentProxyBase(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            string componentCommandNotification = $"{component.Name}Notification";

            builder.AppendLine($"public class Proxy : BlazeProxyComponent<{componentCommandName}, {componentCommandNotification}, {component.ErrorEnum}>");
            builder.AppendLine($"{{");
            builder.AddTab();

            builder.AppendLine($"public Proxy() : base({component.Name}Base.Id, {component.Name}Base.Name)");
            builder.AppendLine($"{{");
            builder.AddTab();
            builder.AppendLine();
            builder.RemoveTab();
            builder.AppendLine($"}}");

            AppendComponentProxyMethods(builder, component);
            builder.AppendLine();

            AppendComponentProxyNotifications(builder, component);
            builder.AppendLine();


            builder.AppendLine($"public override Type GetCommandRequestType({componentCommandName} command) => {component.Name}Base.GetCommandRequestType(command);");
            builder.AppendLine($"public override Type GetCommandResponseType({componentCommandName} command) => {component.Name}Base.GetCommandResponseType(command);");
            builder.AppendLine($"public override Type GetCommandErrorResponseType({componentCommandName} command) => {component.Name}Base.GetCommandErrorResponseType(command);");
            builder.AppendLine($"public override Type GetNotificationType({componentCommandNotification} notification) => {component.Name}Base.GetNotificationType(notification);");
            builder.AppendLine();

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }

        void AppendComponentCommandEnum(CStringBuilder builder, Data.Component component)
        {
            string componentCommandName = $"{component.Name}Command";

            builder.AppendLine($"public enum {componentCommandName} : ushort");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Method method in component.Methods)
                builder.AppendLine($"{method.Name} = {method.Id},");

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }

        void AppendComponentNotificationEnum(CStringBuilder builder, Data.Component component)
        {
            string componentCommandNotification = $"{component.Name}Notification";

            builder.AppendLine($"public enum {componentCommandNotification} : ushort");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Notification notification in component.Notifications)
                builder.AppendLine($"{notification.Name} = {notification.Id},");

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }

        void AppendComponent(CStringBuilder builder, Data.Component component)
        {
            builder.AppendLine($"public static class {component.Name}Base");
            builder.AppendLine($"{{");
            builder.AddTab();

            builder.AppendLine($"public const ushort Id = {component.Id};");
            builder.AppendLine($"public const string Name = \"{component.Name}\";");
            builder.AppendLine();

            AppendComponentServerBase(builder, component);
            builder.AppendLine();

            AppendComponentClientBase(builder, component);
            builder.AppendLine();

            AppendComponentProxyBase(builder, component);
            builder.AppendLine();

            AppendGetCommandRequestType(builder, component);
            builder.AppendLine();

            AppendGetCommandResponseType(builder, component);
            builder.AppendLine();

            AppendGetCommandErrorResponseType(builder, component);
            builder.AppendLine();

            AppendGetNotificationType(builder, component);
            builder.AppendLine();

            AppendComponentCommandEnum(builder, component);
            builder.AppendLine();

            AppendComponentNotificationEnum(builder, component);
            builder.AppendLine();

            builder.RemoveTab();
            builder.AppendLine($"}}");
        }

        private void AppendGetCommandRequestType(CStringBuilder builder, Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            builder.AppendLine($"public static Type GetCommandRequestType({componentCommandName} command) => command switch");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Method method in component.Methods)
            {
                string requestType = method.RequestType;
                if (string.IsNullOrEmpty(requestType))
                    requestType = component.DefaultRequestType;
                builder.AppendLine($"{componentCommandName}.{method.Name} => typeof({requestType}),");
            }

            builder.AppendLine($"_ => typeof({component.DefaultRequestType})");

            builder.RemoveTab();
            builder.AppendLine($"}};");
        }

        private void AppendGetCommandResponseType(CStringBuilder builder, Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            builder.AppendLine($"public static Type GetCommandResponseType({componentCommandName} command) => command switch");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Method method in component.Methods)
            {
                string responseType = method.ResponseType;
                if (string.IsNullOrEmpty(responseType))
                    responseType = component.DefaultResponseType;
                builder.AppendLine($"{componentCommandName}.{method.Name} => typeof({responseType}),");
            }

            builder.AppendLine($"_ => typeof({component.DefaultResponseType})");

            builder.RemoveTab();
            builder.AppendLine($"}};");
        }

        private void AppendGetCommandErrorResponseType(CStringBuilder builder, Component component)
        {
            string componentCommandName = $"{component.Name}Command";
            builder.AppendLine($"public static Type GetCommandErrorResponseType({componentCommandName} command) => command switch");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Method method in component.Methods)
            {
                string errorResponseType = method.ErrorResponseType;
                if (string.IsNullOrEmpty(errorResponseType))
                    errorResponseType = component.DefaultErrorType;
                builder.AppendLine($"{componentCommandName}.{method.Name} => typeof({errorResponseType}),");
            }

            builder.AppendLine($"_ => typeof({component.DefaultErrorType})");

            builder.RemoveTab();
            builder.AppendLine($"}};");
        }

        private void AppendGetNotificationType(CStringBuilder builder, Component component)
        {
            string notificationName = $"{component.Name}Notification";
            builder.AppendLine($"public static Type GetNotificationType({notificationName} notification) => notification switch");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Notification notification in component.Notifications)
            {
                string notificationType = notification.Type;
                if (string.IsNullOrEmpty(notificationType))
                    notificationType = component.DefaultNotificationType;
                builder.AppendLine($"{notificationName}.{notification.Name} => typeof({notificationType}),");
            }

            builder.AppendLine($"_ => typeof({component.DefaultNotificationType})");

            builder.RemoveTab();
            builder.AppendLine($"}};");
        }

        protected override byte[] GenerateCode(string inputFileName, string inputFileContent)
        {
            FileConfig config;
            try
            {
                config = JsonConvert.DeserializeObject<FileConfig>(inputFileContent);
                if (config == null)
                    return StringToBytes("Error: Could not parse BlazeComponentBase JSON file.");
            }
            catch (Exception e)
            {
                return StringToBytes(e.ToString());
            }

            CStringBuilder builder = new CStringBuilder();

            foreach (string use in config.Usings)
                builder.AppendLine($"using {use};");
            builder.AppendLine();
            builder.AppendLine($"namespace {config.Namespace}");
            builder.AppendLine($"{{");
            builder.AddTab();

            foreach (Data.Component component in config.Components)
                AppendComponent(builder, component);

            builder.RemoveTab();
            builder.AppendLine($"}}");



            return StringToBytes(builder.ToString());
        }
    }
}


