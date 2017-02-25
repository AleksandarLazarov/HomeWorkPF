using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Last_3_Consecutive_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ').ToArray();
            string[] newArr = new string[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                newArr[i] = strArr[strArr.Length - 1 - i];
            }

            //string[] newarr = new string[strArr.Length];
            //newarr = strArr.Reverse();
            string lastStr = string.Empty;
            int counter = 1;
            foreach (var str in newArr)
            {
                // Console.WriteLine(str);
                if (lastStr == str)
                {
                    counter++;
                    if (counter == 3)
                    {
                        Console.WriteLine($"{lastStr} {lastStr} {lastStr}");
                        return;
                    }

                }
                else
                {
                    counter = 1;
                }
                lastStr = str;
            }

        }
    }
}
