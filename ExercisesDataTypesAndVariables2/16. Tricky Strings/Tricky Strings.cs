using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string delimite = Console.ReadLine();
        int numStrings = int.Parse(Console.ReadLine());
        string result = "";

        for (int i = 0; i < numStrings; i++)
        {
            string str = Console.ReadLine();
            result += str;
            if (i < numStrings - 1)
            {
                result += delimite;
            }
        }



        Console.WriteLine(result);


    }
}
