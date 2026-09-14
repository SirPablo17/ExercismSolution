static class LogLine
{
    public static string Message(string logLine)
    {
        string [] texto = logLine.Split(":");
        string textoLimpo = texto[1].Trim();
        return textoLimpo;
    }

    public static string LogLevel(string logLine)
    {
        string [] texto = logLine.Split(":");
        string replace = texto[0].Replace("[", "");
        replace = replace.Replace("]", "");

        string resultado = replace.ToLower(); 

        return resultado;
    }

    public static string Reformat(string logLine)
    {
        string retorno = $"{Message(logLine)} ({LogLevel(logLine)})";

        return retorno;
    }
}
