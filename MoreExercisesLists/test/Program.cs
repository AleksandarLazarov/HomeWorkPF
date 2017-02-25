using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(',')','"','\'','\\','/','[',']',' ' };

            List<string> words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < words.Count; i++)
            {
                for (int ii = 0; ii < words[i].Length; ii++)
                {
                    if (words[i][ii]>64&&words[i][ii]<91)
                    {
                        upperCase.Add(words[i]);
                    }
                    else if (words[i][ii] > 96 && words[i][ii] < 123)
                    {
                        lowerCase.Add(words[i]);
                    }
                    else
                    {
                        mixedCase.Add(words[i]);
                    }
                }
            }




            Console.WriteLine(string.Join(" ",lowerCase));
            Console.WriteLine(string.Join(" ", upperCase));
            Console.WriteLine(string.Join(" ", mixedCase));
        }

       
    }
}
