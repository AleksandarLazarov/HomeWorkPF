using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Altitude
{
    class Altitude
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ').ToArray();

            int initialAltitute = int.Parse(strArr[0]);
            

            for (int i = 1; i < strArr.Length; i++)
            {
                if (initialAltitute < 1)
                {
                    Console.WriteLine("crashed");
                    return;
                }
                if (i%2==0)
                {
                    if (strArr[i - 1] == "up")
                    {
                        initialAltitute += int.Parse(strArr[i]);
                    }
                    else if (strArr[i - 1] == "down")
                    {
                        initialAltitute -= int.Parse(strArr[i]);
                    }
                    
                    
                }
            }
            if (initialAltitute>0)
            {
                Console.WriteLine($"got through safely. current altitude: {initialAltitute}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
