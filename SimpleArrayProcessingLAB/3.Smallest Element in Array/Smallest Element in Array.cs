using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] words = str.Split(' ');

            int[] arr = new int[words.Length];
            int i = 0;
            foreach (string num in words)
            {
                arr[i] = int.Parse(num);
                //Console.WriteLine("arr[{0}] = {1}",i,arr[i]);
                i++;
            }
            int min = int.MaxValue;
            foreach (int num in arr)
            {

                if (min > num)
                {
                    min = num;
                }

            }
            Console.WriteLine(min);
        }
    }
}
