using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int obshto = 0;
            int num = 0;
            bool tORf = false;
            for (int ch = 1; ch <= n; ch++)
            {
                num = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                tORf = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine("{0} -> {1}", num, tORf);
                obshto = 0;
                ch = num;
            }
        }
    }
}
