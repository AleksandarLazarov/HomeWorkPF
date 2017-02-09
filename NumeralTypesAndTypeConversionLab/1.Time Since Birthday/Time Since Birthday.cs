using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Time_Since_Birthday
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            int days = num * 365;
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{num} years = {days} days = {hours} hours = {minutes} minutes.");

        }
    }
}
