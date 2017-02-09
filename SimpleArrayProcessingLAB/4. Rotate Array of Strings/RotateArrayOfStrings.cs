using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Rotate_Array_of_Strings
{
    class RotateArrayOfStrings
    {
        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();

            string[] words = inputStr.Split(' ');

            string[] rotateWords = new string[words.Length];
            rotateWords[0] = words[words.Length-1]; 
            for (int i = 1; i < words.Length; i++)
            {
                rotateWords[i] = words[i-1];
            }

            Console.WriteLine(string.Join(" ",rotateWords));

        }
    }
}
