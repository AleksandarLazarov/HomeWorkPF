using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double number = double.Parse(Console.ReadLine());
            string[] words = str.Split(' ');

            double[] arr = new double[words.Length];

            foreach (string num in words)
            {
                Console.Write("{0} ", Convert.ToDouble(num) * number);
            }
        }
    }
}
