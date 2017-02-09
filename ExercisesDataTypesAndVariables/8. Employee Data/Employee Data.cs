using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn = "Amanda";
            string ln = "Jonson";
            int age = 27;
            char gender = 'f';
            long personalID = 8306112507;
            int uniqEmpNum = 27563571;
            Console.WriteLine($"First name: {fn}");
            Console.WriteLine($"Last name: {ln}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {uniqEmpNum}");
        }
    }
}
