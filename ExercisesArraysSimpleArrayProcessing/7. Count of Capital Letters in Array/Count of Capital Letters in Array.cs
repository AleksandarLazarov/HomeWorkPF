using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Count_of_Capital_Letters_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ').ToArray();
            int result = 0; ;

            foreach (var letter in strArr)
            {
                if (letter.Length == 1)
                {
                    if (Char.Parse(letter) > 64 && Char.Parse(letter) < 91)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
//65 90