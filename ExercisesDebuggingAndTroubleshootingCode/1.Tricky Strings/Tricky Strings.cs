﻿using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();
        var numberOfStrings = int.Parse(Console.ReadLine());

        var result = string.Empty;

        for (int i = 0; i < numberOfStrings; i++)
        {
            string currentString = Console.ReadLine();

            result += currentString;
            if (i != numberOfStrings - 1)
            {
                result += delimiter;
            }
        }
        Console.WriteLine(result);

    }
}