using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Stuck_Zipper
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numList2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var newList1 = new List<int>();
            var newList2 = new List<int>();
            
            var minList1 = MinNumLength(numList1);
            var minList2 = MinNumLength(numList2);
            var min = Math.Min(minList1,minList2);
            for (int i = 0; i < numList1.Count; i++)
            {
                if (Math.Abs(numList1[i]).ToString().Length == min)
                {
                    newList1.Add(numList1[i]);
                }
            }

            for (int i = 0; i < numList2.Count; i++)
            {
                if (Math.Abs(numList2[i]).ToString().Length == min)
                {
                    newList2.Add(numList2[i]);
                }
            }

            var resultList = new List<int>();

            for (int i = 0; i < Math.Max(newList1.Count,newList2.Count); i++)
            {
                if (i < newList2.Count)
                {
                    resultList.Add(newList2[i]);
                }
                if (i < newList1.Count)
                {
                    resultList.Add(newList1[i]);
                }
            }

            Console.WriteLine(string.Join(" ",resultList));

        }

        private static int MinNumLength(List<int> numList)
        {
            int result = Math.Abs(numList[0]).ToString().Length;
            string lastStr = string.Empty;
            for (int i = 0; i < numList.Count; i++)
            {
                string currStr = Math.Abs(numList[i]).ToString();
                if (currStr.Length < lastStr.Length)
                {
                    result = Math.Abs(numList[i]).ToString().Length;
                }
                lastStr = currStr;
            }
            return result;
        }
    }
}
