using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.MaxValue;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < n)
                {
                    n = nums[i];
                }
            }

            Console.WriteLine(n);

        }
    }
}
