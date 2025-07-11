using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace EATDF.Types;

public partial struct TimeValue
{
    //time in microseconds
    private long _time;


    [GeneratedRegex(@"^(\d{4})-(\d{2})-(\d{2})T(\d{1,2}):(\d{1,2})(?::(\d{1,2}))?Z$")]
    private static partial Regex accountTimeRegex();


    public long Microseconds { get => _time; set => _time = value; }
    public long Milliseconds { get => _time / 1000; set => _time = value * 1000; }

    public TimeValue()
    {
        _time = 0;
    }


    public TimeValue(long time)
    {
        _time = time;
    }

    public TimeSpan AsTimeSpan()
    {
        long ticks = _time * TimeSpan.TicksPerMicrosecond;
        return new TimeSpan(ticks);
    }

    public DateTime ToDateTime()
    {
        long ticks = _time * TimeSpan.TicksPerMicrosecond;
        return new DateTime(ticks, DateTimeKind.Unspecified);
    }

    public override string ToString()
    {
        return _time.ToString();
    }


    public static bool TryParseAccountTime(string str, out TimeValue timeValue)
    {
        // 2022-04-14T7:9Z or 2022-04-14T7:9:2Z
        timeValue = default;

        if (string.IsNullOrWhiteSpace(str))
            return false;

        var match = accountTimeRegex().Match(str);
        if (!match.Success)
            return false;

        if (!int.TryParse(match.Groups[1].ValueSpan, out int year))
            return false;

        if (!int.TryParse(match.Groups[2].ValueSpan, out int month))
            return false;

        if (!int.TryParse(match.Groups[3].ValueSpan, out int day))
            return false;

        if (!int.TryParse(match.Groups[4].ValueSpan, out int hour))
            return false;

        if (!int.TryParse(match.Groups[5].ValueSpan, out int minute))
            return false;

        int second = 0;

        if (match.Groups[6].Success && !int.TryParse(match.Groups[6].ValueSpan, out second))
            return false;

        if ((month <= 0) || (month > 12))
            month = day = hour = minute = second = 0;
        else if ((day <= 0) || (day > 31))
            day = hour = minute = second = 0;
        else if (hour > 23)
            hour = minute = second = 0;
        else if (minute > 59)
            minute = second = 0;
        else if (second > 60)
            second = 0;

        DateTime time = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Unspecified);
        long microseconds = time.Ticks / TimeSpan.TicksPerMicrosecond;
        timeValue = new TimeValue(microseconds);
        return true;
    }
}