using System.Text;

namespace EATDF.Printer;

public class TabbedStringBuilder
{
    StringBuilder sb = new StringBuilder();
    int tabs = 0;

    public void AppendLine(string str)
    {
        string[] lines = str.Split(new string[] { "\n", "\r\n", "\r" }, StringSplitOptions.None);
        foreach (string line in lines)
        {
            WriteTab();
            sb.AppendLine(line);
        }
    }
    public void AppendLine()
    {
        sb.AppendLine();
    }

    public void Append(string str)
    {
        sb.Append(str);
    }

    public void AppendWithTab(string str)
    {
        WriteTab();
        sb.Append(str);
    }

    public void Append(char c)
    {
        sb.Append(c);
    }

    public void WriteTab()
    {
        sb.Append(' ', tabs * 4);
    }

    public void AddTab()
    {
        tabs++;
    }

    public void RemoveTab()
    {
        tabs--;
    }

    public override string ToString()
    {
        return sb.ToString();
    }
}
