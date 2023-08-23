using System.Text;

namespace BlazeComponentBaseGenerator
{
    public class CStringBuilder
    {
        StringBuilder builder;
        int tabCount;
        public CStringBuilder()
        {
            builder = new StringBuilder();
            tabCount = 0;
        }

        public void AddTab()
        {
            tabCount++;
        }

        public void RemoveTab()
        {
            tabCount--;
            if (tabCount < 0)
                tabCount = 0;
        }

        public void AppendLine(string text)
        {
            for (int i = 0; i < tabCount; i++)
                builder.Append("    ");
            builder.AppendLine(text);
        }

        public void AppendLine()
        {
            for (int i = 0; i < tabCount; i++)
                builder.Append("    ");
            builder.AppendLine();
        }

        public override string ToString()
        {
            return builder.ToString();
        }
    }
}
