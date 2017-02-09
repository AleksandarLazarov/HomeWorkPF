using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            sbyte sbyteMax = sbyte.MaxValue;
            sbyte sbyteMin = sbyte.MinValue;
            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;
            short shortMax = short.MaxValue;
            short shortMin = short.MinValue;
            ushort ushortMax = ushort.MaxValue;
            ushort ushortMin = ushort.MinValue;
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            uint uintMax = uint.MaxValue;
            uint uintMin = uint.MinValue;
            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            if (n > longMax)
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{n} can fit in:");
                if (n <= sbyteMax && n >= sbyteMin)
                {
                    Console.WriteLine("* sbyte");
                }
                if (n <= byteMax && n >= byteMin)
                {
                    Console.WriteLine("* byte");
                }
                if (n <= shortMax && n >= shortMin)
                {
                    Console.WriteLine("* short");
                }
                if (n <= ushortMax && n >= ushortMin)
                {
                    Console.WriteLine("* ushort");
                }
                if (n <= intMax && n >= intMin)
                {
                    Console.WriteLine("* int");
                }
                if (n <= uintMax && n >= uintMin)
                {
                    Console.WriteLine("* uint");
                }
                if (n <= longMax && n >= longMin)
                {
                    Console.WriteLine("* long");
                }
            }




        }
    }
}
