using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            int lightYear = int.Parse(Console.ReadLine());

            decimal oneLightYear = 9450000000000m;
            decimal speedLigthSec = 300000m;

            decimal weeks = lightYear * 365.2240m / 7.0m;
            decimal days = (weeks - Math.Truncate(weeks));
            //decimal hours = 
            //decimal minutes =
            //decimal seconds =
            Console.WriteLine(weeks);
            Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);


        }
    }
}
