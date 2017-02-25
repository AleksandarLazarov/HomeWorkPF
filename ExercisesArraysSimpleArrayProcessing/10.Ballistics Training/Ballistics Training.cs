using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Ballistics_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int planeXCoord = coordinats[0];
            int planeYCoord = coordinats[1];

            string[] strArr = Console.ReadLine().Split(' ').ToArray();

            int yourCordX = 0;
            int yourCordY = 0;

            for (int i = 0; i < strArr.Length; i++)
            {
                if (i % 2 != 0)
                {
                    if (strArr[i - 1] == "up")
                    {
                        yourCordY += int.Parse(strArr[i]);
                    }
                    else if (strArr[i - 1] == "down")
                    {
                        yourCordY -= int.Parse(strArr[i]);
                    }
                    else if (strArr[i - 1] == "left")
                    {
                        yourCordX -= int.Parse(strArr[i]);
                    }
                    else if (strArr[i - 1] == "right")
                    {
                        yourCordX += int.Parse(strArr[i]);
                    }
                }
            }

            Console.WriteLine($"firing at [{yourCordX}, {yourCordY}]");
            if (yourCordX == planeXCoord && yourCordY == planeYCoord)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }


        }
    }
}
