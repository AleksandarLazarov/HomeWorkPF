using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        long num = long.Parse(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());

        int result = FindNTHDigit(num, index);
        Console.WriteLine(result);

    }

    static int FindNTHDigit(long num, int index)
    {
        long result = 0;
        int currIndex = 1;

        while (true)
        {

            if (currIndex == index)
            {
                result = num % 10;
                return (int)result;

            }
            else
            {
                result = num / 10;
            }
            num = result;
            currIndex++;
        }

    }

}
