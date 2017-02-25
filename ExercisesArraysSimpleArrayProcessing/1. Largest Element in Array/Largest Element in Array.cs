using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Largest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNum = new int[n];
            int largest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                arrNum[i] = int.Parse(Console.ReadLine());
                if (largest<arrNum[i])
                {
                    largest = arrNum[i];
                }
            }
            Console.WriteLine(largest);

        }
    }
}
