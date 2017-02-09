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


        int smaller = GetMin(a, b);
        if (smaller < c)
        {
            Console.WriteLine(smaller);
        }
        else
        {
            Console.WriteLine(c);
        }

    }

    static int GetMin(int a, int b)
    {
        int result = Math.Min(a, b);
        return result;
    }
}
