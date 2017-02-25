using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Increasing_Sequence_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastNum = int.MinValue;
            string result = string.Empty;
            foreach (var num in intArr)
            {
                if (lastNum<num)
                {
                    result = "Yes";
                }
                else
                {
                    result = "No";
                    Console.WriteLine(result);
                    return;
                }
                lastNum = num;
            }
            Console.WriteLine(result);

        }
    }
}
