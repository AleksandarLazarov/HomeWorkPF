using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object str = str1 + " " + str2;
            string str3 = (string)str;
            Console.WriteLine(str3);

        }
    }
}
