using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shoot_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbreCount = 0;
            int strCount = 0;
            var num = new List<int>();
            var input = Console.ReadLine();
            int lastRemoved = 0;
            while (input != "stop")
            { 
                if (input == "bang")
                {
                    strCount++;
                    double avr = num.Count > 0 ? num.Average() : 0;

                    if (num.Count == 0 && strCount>numbreCount)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        return;
                    }
                    for (int i = 0; i < num.Count; i++)
                    {                                                
                        if (num.Count > 0 && avr > num[i])
                        {
                            lastRemoved = num[i];
                            Console.WriteLine($"shot {num[i]}");
                            num.RemoveAt(i);
                            
                            for (int ii = 0; ii < num.Count; ii++)
                            {
                                num[ii]--;
                            }
                            if (num.Count == 1)
                            {
                                lastRemoved = num[0];
                                Console.WriteLine($"shot {num[0]}");
                                num.RemoveAt(0);
                            }
                            break;
                        }
                        if (num.Count==0)
                        {
                            break;
                        }
                    }
                    
                }
                else
                {
                    num.Insert(0,int.Parse(input));
                    numbreCount++;
                }

                input = Console.ReadLine();

            }
            if (num.Count==0)
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }
            if (input=="stop" && num.Count>0)
            {
                Console.WriteLine("survivors: " + string.Join(" ", num));
            }
            

        }
    }
}
