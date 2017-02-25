using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Array_Elements_Equal_to_Their_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] strArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i == strArr[i])
                {
                    Console.Write($"{strArr[i]} ");
                }
            }



        }
    }
}
