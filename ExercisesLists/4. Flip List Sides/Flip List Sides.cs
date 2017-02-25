using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var numList2 = new List<string>();

            for (int i = 1; i < numList.Count/2; i++)
            {
                int first = numList[numList.Count - i - 1];
                int last = numList[i];
                numList[i] = first;
                numList[numList.Count - i - 1] = last;
            }

            Console.WriteLine(string.Join(" ",numList));
        }
    }
}
