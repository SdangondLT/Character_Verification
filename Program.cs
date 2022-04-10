using System;
using System.Text.RegularExpressions;

namespace characterVerification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Ingrese la cadena que desea verificar: ");
                string chainToVerify = Console.ReadLine();
                Console.WriteLine($"Esta es su cadena verificada y editada: {CharacterVerification(chainToVerify)}");
            } while (true);
        }

        public static string CharacterVerification(string message)
        {
            Regex regex = new Regex(@"[^\w\s\d-_]");
            string resultRegex = regex.Replace(message, "");
            if (resultRegex != "")
                return resultRegex;
            else
                return "NA";
        }
    }
}
