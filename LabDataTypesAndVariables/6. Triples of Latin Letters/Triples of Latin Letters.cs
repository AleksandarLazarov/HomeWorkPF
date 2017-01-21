using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char i1 = 'a'; i1 < 'a' + n; i1++)
                {
                    for (char i2 = 'a'; i2 < 'a' + n; i2++)
                    {
                        Console.Write(i);
                        Console.Write(i1);
                        Console.WriteLine(i2);
                    }

                }
            }
        }
    }
}
