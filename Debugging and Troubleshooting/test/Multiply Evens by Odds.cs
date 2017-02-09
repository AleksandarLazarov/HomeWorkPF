using System;
namespace test
{
    class test
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            num = Math.Abs(num);
            long result = GetMultipleOfEvensAndOdds(num);
            Console.WriteLine(result);
        }

        private static long GetMultipleOfEvensAndOdds(int num)
        {
            
            int sumOdd = GetSumOdd(num);
            int sumEven = GetSumEven(num);
            long result = sumOdd * sumEven;
            return result;
        }

        private static int GetSumOdd(int num)
        {
            int lastDigit = 0;
            int result = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    result += lastDigit;
                }
                num /= 10;
            }
            return result;
        }

        private static int GetSumEven(int num)
        {
            int lastDigit = 0;
            int result = 0;
            while (num != 0)
            {
                lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    result += lastDigit;
                }
                num /= 10;
            }
            return result;
        }
    }
}
