using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var str = Console.ReadLine();
        int countRepeat = int.Parse(Console.ReadLine());

        string result = RepeatString(str, countRepeat);
        Console.WriteLine(result);

    }

    static string RepeatString(string str, int countRepeat)
    {
        string result = string.Empty;
        for (int i = 0; i < countRepeat; i++)
        {
            result += str;
        }

        return result;
    }
}
