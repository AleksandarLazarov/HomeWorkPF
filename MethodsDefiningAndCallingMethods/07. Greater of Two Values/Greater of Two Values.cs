﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        int first = int.Parse(Console.ReadLine());
                        int second = int.Parse(Console.ReadLine());
                        int max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }
                case "char":
                    {
                        char first = char.Parse(Console.ReadLine());
                        char second = char.Parse(Console.ReadLine());
                        char max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }
                case "string":
                    {
                        string first = Console.ReadLine();
                        string second = Console.ReadLine();
                        string max = GetMax(first, second);
                        Console.WriteLine(max);
                        break;
                    }
            }


        }

        private static int GetMax(int first,int second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }

        private static char GetMax(char first, char second)
        {
            if (first >= second)
            {
                return first;
            }
            return second;
        }

        private static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }

    }
}
