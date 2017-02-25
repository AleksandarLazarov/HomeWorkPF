using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ').ToArray();

            string[] names = Console.ReadLine().Split(' ').ToArray();
            string name = string.Empty;
            while (name != "done")
            {
                name = Console.ReadLine();
                
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i] )
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }

            }

        }
    }
}
