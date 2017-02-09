using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I.Declaring_and_Invoking_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintStudent(5, 5.5));


            var number = 4.5;
            //PrintHeader();

            Console.WriteLine("Number = " + GetSquare(number));
            PrintFooter();
        }
        

        static double PrintStudent(int age, double grade)
        {
            double result = age + grade;
            return result;
        }

        static void PrintFooter()
        {
            Console.WriteLine("-- -- -- -- -- -- -- -- -- -- -- -- -- -- --");
            Console.WriteLine("© SoftUni");
        }

        static double GetSquare(double num)    //Method-ite imat tip kogato vrashtat rezultat
        {
            return num;
        }

        //static void PrintHeader()
        //{
        //    Console.WriteLine("-----------"); 
        //}
    }
}
