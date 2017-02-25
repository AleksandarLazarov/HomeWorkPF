using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Tear_List_in_Half
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var leftHalf = new List<int>();
            var rightHalf = new List<int>();
            int ii = 0;
            for (int i = numList.Count/2; i < numList.Count; i++)
            {
                leftHalf.Add(numList[ii]);
                rightHalf.Add(numList[i]);
                ii++;
            }

            //Console.WriteLine(string.Join(" ", leftHalf));
            //Console.WriteLine(string.Join(" ", rightHalf));

            
            var resultList = new List<int>();
            //int indexRightHalf = 0;
            for (int i = 0; i < numList.Count / 2; i++)
            {
                resultList.Add(Desetici(rightHalf[i]));
                resultList.Add(leftHalf[i]);
                resultList.Add(Edinici(rightHalf[i]));
                //numList.Insert(i, Desetici(rightHalf[index2]));
                //numList.Insert(i + 2, Edinici(rightHalf[index2]));
                //indexRightHalf++;
            }

            Console.WriteLine(string.Join(" ", resultList));
            
        }

        private static int Desetici(int num)
        {
            int result = num / 10;
            return result;
        }

        private static int Edinici(int num)
        {
            int result = num % 10;
            return result;
            
        }
    }
}
