using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currNum = i;
                int sum = 0;
                bool specialOrNot = false;

                while (currNum != 0)
                {
                    sum += currNum % 10;
                    currNum /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    specialOrNot = true;
                }
                Console.WriteLine($"{i} -> {specialOrNot}");
            }
        }
    }
}
