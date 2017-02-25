using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class ArrayContainsElement
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());

            bool contains = false;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == n)
                {
                    contains = true;
                    break;
                }
            }

            Console.WriteLine(contains ? "yes" : "no");

        }
    }
}
