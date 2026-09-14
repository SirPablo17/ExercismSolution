static class LogLine
{
    public static string Message(string logLine)
    {
        string [] texto = logLine.Split(":");
        return texto[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string [] texto = logLine.Split(":");
        string replace = texto[0].Replace("[", "");
        replace = replace.Replace("]", "");

        return replace.ToLower(); 
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
