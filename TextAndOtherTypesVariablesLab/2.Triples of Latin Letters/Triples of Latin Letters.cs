using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a'+ n; i++)
            {
                for (char ii = 'a'; ii < 'a' + n; ii++)
                {
                    for (char iii = 'a'; iii < 'a' + n; iii++)
                    {
                        Console.WriteLine($"{i}{ii}{iii}");
                    }
                }
            }
        }
    }
}
