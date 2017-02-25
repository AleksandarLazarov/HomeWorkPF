using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Remove_Elements_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            var list2 = new List<string>();
            //list2.Add("Test");
            for (int i = 1; i <list.Count; i+=2)
            {
                list2.Add(list[i]);
            }

            Console.WriteLine(string.Join("",list2));

        }
    }
}
