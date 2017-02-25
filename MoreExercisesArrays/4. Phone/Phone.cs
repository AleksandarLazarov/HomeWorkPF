using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');

            string[] names = Console.ReadLine().Split(' ').ToArray();
            string[] nameOrPhone = new string[2];
            while (nameOrPhone[0] != "done")
            {
                nameOrPhone = Console.ReadLine().Split(' ');
                
                if (nameOrPhone[0] == "call")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (nameOrPhone[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"calling {names[i]}...");
                            CallResult(phoneNumbers[i]);
                        }
                        else if (nameOrPhone[1] == names[i])
                        {
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            CallResult(phoneNumbers[i]);
                        }
                    }
                }
                else if (nameOrPhone[0] == "message")
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (nameOrPhone[1] == phoneNumbers[i])
                        {
                            Console.WriteLine($"sending sms to {names[i]}...");
                            MessageResult(phoneNumbers[i]);
                        }
                        else if (nameOrPhone[1] == names[i])
                        {
                            Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                            MessageResult(phoneNumbers[i]);
                        }
                    }
                }

            }
        }

        private static void MessageResult(string phoneNumbers)
        {
            int result = 0;
            foreach (var digit in phoneNumbers)
            {
                if (digit > 47 && digit < 58)
                {
                    result -= digit - 48;
                }
            }
            if (result % 2 == 0)
            {
                Console.WriteLine("meet me there");
            }
            else
            {
                Console.WriteLine("busy");
            }
        }



        private static void CallResult(string phoneNumbers)
        {
            int result = 0;
            foreach (var digit in phoneNumbers)
            {
                if (digit>47 && digit<58)
                {
                    result += digit - 48;
                }
            }
            if (result%2==0)
            {
                TimeSpan time = TimeSpan.FromSeconds(result);
                string duration = time.ToString("mm':'ss");
                Console.WriteLine($"call ended. duration: {duration}");

            }
            else
            {
                Console.WriteLine("no answer");
            }
        }
    }
}
