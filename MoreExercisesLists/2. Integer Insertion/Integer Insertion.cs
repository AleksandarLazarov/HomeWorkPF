using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var strList = new List<string>();
            var str = string.Empty;
            while (str != "end")
            {
                str = Console.ReadLine();
                if (str != "end")
                {
                    strList.Add(str);
                }
            }

            for (int i = 0; i < strList.Count; i++)
            {
                int index = GetFirstDigit(strList[i]);
                numList.Insert(index,int.Parse(strList[i]));
            }

            Console.WriteLine(string.Join(" ",numList));

        }

        private static int GetFirstDigit(string str)
        {
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result = str[0] - 48;
                break;
            }

            return result;
        }
    }
}
