using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int[] arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                int n = int.Parse(Console.ReadLine());
                arr[i] = n;
            }

            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
