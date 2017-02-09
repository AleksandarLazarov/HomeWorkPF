using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            PrintFigurre(n);
        }

        private static void PrintFigurre(int n)
        {
            PrintHeader(n);
            PrintBody(n);
            PrintFooter(n);
        }

        static void PrintHeader(int n)
        {
            Console.WriteLine(new String('-', n * 2));
        }

        static void PrintFooter(int n)
        {
            PrintHeader(n);
        }

        static void PrintBody(int number)
        {
            for (int i = 0; i < number-2; i++)
            {
                string body = "-";
                for (int row = 0; row < number-1; row++)
                {
                    body += @"\/";
                }
                body += "-";
                Console.WriteLine(body);
            }
        }
    }
}
