using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int numOld = 0;
            int num = 0;
            for (int i = 1; i <= n; i++)
            {
                sum = 0;
                numOld++;
                num = numOld;
                while (num != 0)
                {
                    sum += (num % 10);
                    num = num / 10;
                    //Console.WriteLine("{0} -> Sum",sum);
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine("{0} -> True", numOld);
                }
                else
                {
                    Console.WriteLine("{0} -> False", numOld);
                }
            }
        }
    }
}
