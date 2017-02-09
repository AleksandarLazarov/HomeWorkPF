using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            int numPow = int.Parse(Console.ReadLine());

            Console.WriteLine(PowNumber(numOne, numPow));
            
        }

        static double PowNumber(double numOne, int numPow)
        {
            return Math.Pow(numOne,numPow);
        }
    }
}
