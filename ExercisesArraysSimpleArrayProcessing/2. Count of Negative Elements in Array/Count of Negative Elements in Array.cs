using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Count_of_Negative_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrNum = new int[n];
            int countNegativ = 0;
            for (int i = 0; i < n; i++)
            {
                arrNum[i] = int.Parse(Console.ReadLine());
                if (0 > arrNum[i])
                {
                    countNegativ++;
                }
            }
            Console.WriteLine(countNegativ);

        }
    }
}
