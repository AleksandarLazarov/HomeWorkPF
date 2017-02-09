using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        float meters = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());
        float mile = 1609;

        float metPerSec = meters / (((hours * 60 + minutes) * 60) + seconds);
        float kiloPerHour = (meters / 1000) / ((hours + minutes / 60) + seconds / 3600);
        float milPerHour = (meters / mile) / ((hours + minutes / 60) + seconds / 3600);

        Console.WriteLine("{0:0.######}", metPerSec);
        Console.WriteLine("{0:0.######}", kiloPerHour);
        Console.WriteLine("{0:0.######}", milPerHour);

    }
}

