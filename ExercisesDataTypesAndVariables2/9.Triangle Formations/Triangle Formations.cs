using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        string result1 = "";
        string result2 = "";

        if (a + b < c || a + c < b || c + b < a)
        {
            result1 = "Invalid Triangle.";
            Console.WriteLine(result1);
            return;
        }
        else
        {
            result1 = "Triangle is valid.";
            if (Math.Pow(a,2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                result2 = "Triangle has a right angle between sides a and b";
            }
            else if (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
            {
                result2 = "Triangle has a right angle between sides a and c";
            }
            else if (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2))
            {
                result2 = "Triangle has a right angle between sides c and b";
            }
            else
            {
                result2 = "Triangle has no right angles";
            }


        }
        Console.WriteLine(result1);
        Console.WriteLine(result2);

    }
}
