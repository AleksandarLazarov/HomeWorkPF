using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Power_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var plants = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            long daySurvived = 0;

            while (plants.Sum() != 0)
            {
                if (daySurvived == plants.Length && (daySurvived - 1)!=0)
                {
                    plants[daySurvived - 1]++;
                }
                for (long i = 0; i < plants.Length; i++)
                {
                    if (daySurvived == i && plants[i] != 0)
                    {
                        plants[i]++;
                    }
                    if (plants[i] != 0)
                    {
                        plants[i]--;
                    }
                }
                daySurvived++;

            }
            long seasonsCount = 0;
            if (daySurvived > plants.Length)
            {
                seasonsCount = daySurvived / plants.Length;
            }
            string seasons = "seasons";
            if (seasonsCount==1)
            {
                seasons = "season";
            }

            Console.WriteLine($"survived {daySurvived} days ({seasonsCount} {seasons})");


        }
    }
}
