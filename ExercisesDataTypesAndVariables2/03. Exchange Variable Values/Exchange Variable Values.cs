using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = num2;
        num2 = num1;
        num1 = num3;

        Console.WriteLine(num1);
        Console.WriteLine(num2);

    }
}
