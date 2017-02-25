using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Resizable_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var command = new List<string>();
            do
            {
                command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "push")
                {
                    list.Add(int.Parse(command[1]));
                }
                else if (command[0] == "pop")
                {
                    list.RemoveAt(list.Count - 1);
                }
                else if (command[0] == "removeAt")
                {
                    list.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "clear")
                {
                    list.RemoveRange(0, list.Count);
                }

            } while (command[0] != "end");

            if (list.Count==0)
            {
                Console.WriteLine("empty array");
            }
            else
            {
                Console.WriteLine(string.Join(" ", list));
            }
           
        }
    }


}
