using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_of_Given_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int result = 0;

            string[] arrStr = str.Split(' ');

            int[] intArr = new int[arrStr.Length];

            for (int i = 0; i < arrStr.Length; i++)
            {
                intArr[i] = int.Parse(arrStr[i]);
                if (intArr[i] == num)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}
