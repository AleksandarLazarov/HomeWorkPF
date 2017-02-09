using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char currentChar = char.Parse(Console.ReadLine());
                var encripted = Encript(currentChar);
                result += encripted;
            }
            Console.WriteLine(result);
        }

        private static string Encript(char currentChar)
        {
            var asciiCode = (int)currentChar;
            var firstDigit = GetFirstDigit(asciiCode);
            var lastDigit = currentChar % 10; ;

            var firstSymbol = (char)(asciiCode + lastDigit);
            var lastSymbol = (char)(asciiCode - firstDigit);

            string result = $"{firstSymbol}{firstDigit}{lastDigit}{lastSymbol}";

            return result;
        }

        private static int GetFirstDigit(int asciiCode)
        {
            var firstDigit = asciiCode;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            return firstDigit;
        }
    }
}
