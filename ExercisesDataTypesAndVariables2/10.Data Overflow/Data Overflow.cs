using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Cypher_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());

            string result1 = "";
            ulong smaller = Math.Min(num1, num2);
            double smallerType = byte.MaxValue;
            string smalType = "";

            if (byte.MinValue <= smaller && smaller <= byte.MaxValue)
            {
                result1 = "smaller type: byte";
                smaller = (byte)smaller;
                smalType = "byte";
            }
            else if (ushort.MinValue <= smaller && smaller <= ushort.MaxValue)
            {
                result1 = "smaller type: ushort";
                smaller = (ushort)smaller;
                smallerType = ushort.MaxValue;
                smalType = "ushort";
            }
            else if (uint.MinValue <= smaller && smaller <= uint.MaxValue)
            {
                result1 = "smaller type: uint";
                smaller = (uint)smaller;
                smallerType = uint.MaxValue;
                smalType = "uint";
            }
            else if (ulong.MinValue <= smaller && smaller <= ulong.MaxValue)
            {
                result1 = "smaller type: ulong";
                smallerType = ulong.MaxValue;
                smalType = "ulong";
            }

            string result2 = "";
            ulong bigger = Math.Max(num1, num2);

            if (byte.MinValue <= bigger && bigger <= byte.MaxValue)
            {
                result2 = "bigger type: byte";
                bigger = (byte)bigger;
            }
            else if (ushort.MinValue <= bigger && bigger <= ushort.MaxValue)
            {
                result2 = "bigger type: ushort";
                bigger = (ushort)bigger;
            }
            else if (uint.MinValue <= bigger && bigger <= uint.MaxValue)
            {
                result2 = "bigger type: uint";
                bigger = (uint)bigger;
            }
            else if (ulong.MinValue <= bigger && bigger <= ulong.MaxValue)
            {
                result2 = "bigger type: ulong";
            }

            Console.WriteLine(result2);
            Console.WriteLine(result1);
            Console.WriteLine("{0} can overflow {1} {2} times", bigger, smalType, Math.Round(bigger / smallerType));


        }
    }
}
