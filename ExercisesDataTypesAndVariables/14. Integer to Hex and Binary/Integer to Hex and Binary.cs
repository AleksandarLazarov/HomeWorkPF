using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            var hex = n.ToString("X");

            Console.WriteLine(hex);
            Console.WriteLine(binary);

        }
    }
}
