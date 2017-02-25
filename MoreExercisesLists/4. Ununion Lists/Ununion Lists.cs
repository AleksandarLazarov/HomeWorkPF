using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var currentList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                
                for (int ii = 0; ii < currentList.Count; ii++)
                {
                    if (primalList.Contains(currentList[ii]))
                    {
                        primalList.RemoveAll(item => item == currentList[ii]);
                    }
                    else
                    {
                        primalList.Add(currentList[ii]);
                    }
                }
                currentList.Clear();

            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList));

        }
    }
}
