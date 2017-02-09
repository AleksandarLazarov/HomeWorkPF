using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        double teraByte = double.Parse(Console.ReadLine());
        double bite = (teraByte * 1024 * 1024 * 1024 * 1024 * 8);

        Console.WriteLine(bite);


    }
}
