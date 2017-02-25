using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Equal_Sequence_of_Elements_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int lastNum = int.MinValue;
            int firstArrNum = intArr[0];


            for (int i = 0; i < intArr.Length; i++)
            {
                if (firstArrNum != intArr[i])
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            
                Console.WriteLine("Yes");
            
        }
    }
}
