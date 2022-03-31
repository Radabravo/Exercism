using System;

static class LogLine
{
    public static string Message(string logLine)
    {

        char[] delimiters = new char[] { ' ', '\t', '\r', '\n' };
        string[] strings = logLine.Split(delimiters);
        string log = null;
        var size = strings.Length;
        for (int i = 1; i < size; i++)
        {
            log += strings[i] + " ";
        }
        var logTrim = log.Trim();

        return logTrim;
    }

    public static string LogLevel(string logLine)
    {
        char[] delimiters = new char[] { '[', ']' };
        string[] strings = logLine.Split(delimiters);
        string log = null;
        var size = strings.Length;

        log += strings[1] + " ";

        var logTrim = log.Trim();

        return logTrim.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string reformat = Message(logLine) + " (" + LogLevel(logLine) + ")";
        return reformat;
    }
}

