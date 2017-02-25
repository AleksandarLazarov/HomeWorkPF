using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var numList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int sizeM = int.Parse(Console.ReadLine());
            if (sizeM == numList.Count)
            {
                Console.Write("already stable: ");
                Console.WriteLine(string.Join(" ", numList));
                return;
            }

            int rounds = 0;
            for (int i = 0; i < numList.Count; i++)
            {
                numList.RemoveAt(0);
                numList.RemoveAt(numList.Count-1);
                rounds++;
                if (sizeM == numList.Count)
                {
                    break;
                }
            }
            
            
                Console.WriteLine($"{rounds} rounds");
                Console.Write("remaining: ");
                Console.WriteLine(string.Join(" ", numList));

        }
    }
}
