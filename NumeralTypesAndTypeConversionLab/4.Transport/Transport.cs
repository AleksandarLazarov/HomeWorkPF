using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Transport
{
    class Transport
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());

            int result = 0;
            if (persons % 24 > 0)
            {
                result = persons / 24;
                result++;
            }
            else
            {
                result = persons / 24;
            }
            Console.WriteLine(result);
        }
    }
}
