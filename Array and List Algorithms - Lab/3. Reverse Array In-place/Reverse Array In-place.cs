using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();


            for (int i = 0; i < nums.Count / 2; i++)
            {
                int temp = nums[i];
                nums[i] = nums[nums.Count - 1 - i];
                nums[nums.Count - 1 - i] = temp;
            }

            Console.WriteLine(String.Join(" ", nums));

        }
    }
}
