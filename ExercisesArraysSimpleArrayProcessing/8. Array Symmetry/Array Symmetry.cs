using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Array_Symmetry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ').ToArray();
            int decrement = strArr.Length-1;

            bool result = false;

            for (int i = 0; i < strArr.Length/2; i++,decrement--)
            {
                if (strArr[i] != strArr[decrement])
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
