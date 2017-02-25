using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine());


            bool flag = true;
            int temp;
            int numLength = nums.Count;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (nums[j + 1] > nums[j])
                    {
                        temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            int count = 0;
            foreach (var num in nums)
            {
                if (count == n)
                {
                    break;
                }
                Console.Write("{0} ", num);
                count++;

            }
        }
    }
}
