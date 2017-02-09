using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;
            int currNum = 0;
            bool isSpecialNum = false;

            for (int num = 1; num <= lastNumber; num++)
            {
                currNum = num;

                while (num > 0)
                {
                    sumOfDigits += num % 10;
                    num = num / 10;

                }

                isSpecialNum = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);

                Console.WriteLine($"{currNum} -> {isSpecialNum}");
                sumOfDigits = 0;
                num = currNum;
            }

        }
    }
}
