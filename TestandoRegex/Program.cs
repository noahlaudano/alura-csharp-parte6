using System;
using System.Text.RegularExpressions;

namespace TestandoRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4}[-][0-9]{4}";
            // string padrao = "[0-9]{4}-[0-9]{4}";
            // string padrao = "[0-9]{4,5}-[0-9]{4}";
            // string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string texto = "Meu número é: 923423453";

            Match match = Regex.Match(texto, padrao);
            Console.WriteLine(match.Value);
            Console.ReadLine();

        }
    }
}
