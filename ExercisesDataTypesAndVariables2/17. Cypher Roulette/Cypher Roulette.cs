using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int numStrings = int.Parse(Console.ReadLine());
        string result = "";
        string lastStr = "";
        string str = "";
        int spin = 0;

        for (int i = 0; i < numStrings; i++)
        {
            lastStr = str;
            str = Console.ReadLine();
            if (str == lastStr)
            {
                result = "";
                
                if (str == "spin")
                {
                    i--;
                    spin = 0;

                }
                str = "";
                continue;
            }

            if (str == "spin")
            {
                i--;
                spin++;
                
            }
            else
            {
                if (spin == 1)
                {
                    result = str + result;
                    //if (lastStr != "spin")
                    //{
                    //    spin = 0;
                    //}
                }
                else if (spin == 2)
                {
                    result += str;
                    spin = 0;
                }
                else
                {
                    result += str;
                }
            }
        }
        Console.WriteLine(result);

    }
}
