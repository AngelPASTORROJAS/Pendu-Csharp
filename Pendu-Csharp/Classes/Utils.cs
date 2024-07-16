using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendu_Csharp.Classes
{
    internal class Utils
    {
        public static char[] RandomWord()
        {
            Random random = new Random();
            string[] motsATrouver = ["Testeur", "POO", "Classe", "Variable", "SQL"];
            return motsATrouver[random.Next(motsATrouver.Length)].ToArray();
        }

        public static char RandomMask()
        {
            Random random = new Random();
            char[] masques = ['*', '-', '+', '_'];
            return masques[random.Next(masques.Length)];
        }

        public static bool IsSameToUpperChar(char ch1, char ch2)
        {
            return char.ToUpper(ch1) == char.ToUpper(ch2);
        }

        public static bool ArrayCharContainsToUpperChar(char[] ch1, char ch2)
        {
            return Array.Exists(ch1, c => char.ToUpper(c) == char.ToUpper(ch2));
        }

        public static char InputChar(string messageInput, string messageError)
        {
            Console.Write(messageInput);
            bool existLettre = char.TryParse(Console.ReadLine(), out char lettre);
            while (!(existLettre && char.IsLetter(lettre)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existLettre = char.TryParse(Console.ReadLine(), out lettre);
            }
            return lettre;
        }

        public static int InputInt(string messageInput, string messageError, bool isPositive = false)
        {
            Console.Write(messageInput);
            bool existInt = int.TryParse(Console.ReadLine(), out int result);
            if (isPositive && existInt)
            {
                existInt &= result >= 0;
            }
            while (!existInt)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(messageError);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(messageInput);
                existInt = int.TryParse(Console.ReadLine(), out result);
                if (isPositive && existInt)
                {
                    existInt = existInt && result >= 0;
                }
            }
            return result;
        }

        public static string InputString(string messageInput, string messageError, bool isEmptyOrNull = false, string[]? container = null)
        {
            Console.Write(messageInput);
            string? result = Console.ReadLine();
            if (isEmptyOrNull)
            {
                while (string.IsNullOrEmpty(result))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messageError);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(messageInput);
                    result = Console.ReadLine();
                }
            }
            if (container?.Any() ?? false)
            {
                while (!(container?.Contains(result) ?? false))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(messageError);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(messageInput);
                    result = Console.ReadLine();
                }
            }
            return string.IsNullOrEmpty(result) ? "" : result;
        }
    }
}