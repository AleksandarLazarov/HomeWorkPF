using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Count_Occurrences_of_Larger_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double p = double.Parse(Console.ReadLine());
            double countOfBiggers = 0;

            string[] arrStr = str.Split(' ');

            double[] doubleArr = new double[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                doubleArr[i] = double.Parse(arrStr[i]);
                if (doubleArr[i] > p)
                {
                    countOfBiggers++;
                }
            }
            Console.WriteLine(countOfBiggers);

        }
    }
}
