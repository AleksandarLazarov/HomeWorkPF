using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sum_After_Extraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numList2.Count; i++)
            {
                for (int ii = 0; ii < numList.Count; ii++)
                {
                    if (numList2[i] == numList[ii])
                    {
                        numList2.Remove(numList2[i]);
                        i = -1;
                        ii = 0;
                        break;
                    }

                }

            }

            if (numList2.Sum() == numList.Sum())
            {
                Console.WriteLine($"Yes. Sum: {numList2.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(numList2.Sum() - numList.Sum())}");
            }

        }
    }
}
