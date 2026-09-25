using System;
using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        if (identifier == "")
        {
            return "";
        }

        StringBuilder identificadorLimpo = new StringBuilder();
        bool isCamelCase = false;
        
        
        for (int i = 0; i < identifier.Length; i++)
        {
            char caractereAtual = identifier[i];
            bool isGregaMinuscula = caractereAtual >= 'α' && caractereAtual <= 'ω';

            if ((Char.IsLetter(caractereAtual) || caractereAtual == '_') && isGregaMinuscula == false)
            {
                if (isCamelCase == true)
                {
                    identificadorLimpo.Append(Char.ToUpper(caractereAtual)); 
                    isCamelCase = false;
                } 
                else 
                {
                    identificadorLimpo.Append(caractereAtual);
                }
            } 
            else if (caractereAtual == ' ')
            {
                identificadorLimpo.Append('_');
            } 
            else if (Char.IsControl(caractereAtual))
            {
                identificadorLimpo.Append("CTRL");
            } 
            else if (caractereAtual == '-')
            {
                isCamelCase = true;
            }
            
        }
            
        return identificadorLimpo.ToString();
    }
}