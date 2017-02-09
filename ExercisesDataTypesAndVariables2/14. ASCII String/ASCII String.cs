using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string result = "";
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            result += (char)num;
        }


        Console.WriteLine(result);

    }
}
