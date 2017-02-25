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
            List<int> list = new List<int>(new int[] { 2, 3, 7 });
            Console.WriteLine(string.Join(" ",list));
            list.Insert(1,8);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
