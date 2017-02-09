using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        byte increment = 0;
        int overflow = 0;
        for (int i = 0; i < num; i++)
        {
            increment++;
            if (increment == 0)
            {
                overflow++;
            }

        }

        Console.WriteLine(increment);
        if (overflow > 0)
        {
            Console.WriteLine("Overflowed {0} times", overflow);
        }

    }
}
