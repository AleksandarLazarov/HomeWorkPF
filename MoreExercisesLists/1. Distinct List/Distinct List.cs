using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var distinct = numList.Distinct().ToList();

            Console.WriteLine(string.Join(" ", distinct));
            */


            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numList.Count; i++)
            {
                for (int ii = i+1; ii < numList.Count; ii++)
                {
                    if (numList[i]==numList[ii])
                    {
                        numList.RemoveAt(ii);
                    }
                }
                
            }

            Console.WriteLine(string.Join(" ",numList));
            
        }
    }
}
