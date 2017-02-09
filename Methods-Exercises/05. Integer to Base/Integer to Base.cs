using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int toBase = int.Parse(Console.ReadLine());

        string result = IntegerToBase(number, toBase);
        Console.WriteLine(result);

    }

    static string IntegerToBase(int number, int toBase)
    {
        
        string result = string.Empty;
        
            while (number!=0)
            {
                int reminder = number % toBase;
                result = reminder + result;
                number /= toBase;

            }

        return result;
    }

}
