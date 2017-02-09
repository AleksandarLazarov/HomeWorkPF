using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        double num1 = 4.22;
        double num2 = 26000;
        double num3 = 100000;
        double num4 = 46500000000;
        double num5 = 9450000000000;

        Console.WriteLine((num1 * num5).ToString("e2"));
        Console.WriteLine((num2 * num5).ToString("e2"));
        Console.WriteLine((num3 * num5).ToString("e2"));
        Console.WriteLine((num4 * num5).ToString("e2"));

    }
}
