using System;
using System.Linq;

public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string ch)
    {
        char[] delimiters = ch.ToCharArray();
     
        string[] strings = str.Split(ch);
        string log = null;
        var size = strings.Length;
        for (int i = 1; i < size; i++)
        {
            log += strings[i];
        }
        //var logTrim = log.Trim();

        return log;
    }

    public static string SubstringBetween(this string str, string ch, string ch2)
    {
        char[] delimiterb = ch.ToCharArray();
        char[] delimiterf = ch2.ToCharArray();
        Console.WriteLine(ch);

        string[] strings = str.Split(delimiterb);
        string log = null;
        var size = strings.Length;
        log += strings[1];
        string[] log1 = log.Split(delimiterf);
        
        //var logTrim = log.Trim();

        return log1[0];
    }
    public static string Message(this string str)
    {
        string[] strings = str.Split(":");
        string log = null;
        var size = strings.Length;
        return strings[1].Trim();
    }
    public static string LogLevel(this string str)
    {
        var log = str.SubstringBetween("[", "]");
        return log;
    }
   

    // TODO: define te 'SubstringBetween()' extension method on the `string` type

    // TODO: define the 'Message()' extension method on the `string` type

    // TODO: define the 'LogLevel()' extension method on the `string` type
}