﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Count_of_Odd_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] numberStr = str.Split(' ');

            int[] number = new int[numberStr.Length];
            int odd = 0;
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = int.Parse(numberStr[i]);
                if (number[i] % 2 != 0)
                {
                    odd++;
                }
            }
            Console.WriteLine(odd);
        }
    }
}
