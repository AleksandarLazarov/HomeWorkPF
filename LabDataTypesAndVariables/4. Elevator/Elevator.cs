using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double sum = n / p;
            Console.WriteLine("{0}", Math.Ceiling(sum));
        }
    }
}
