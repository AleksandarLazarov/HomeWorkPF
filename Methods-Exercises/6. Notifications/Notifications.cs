using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();
                if (result == "success")
                {
                    string operation = Console.ReadLine();
                    string message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation, message));
                }
                else if (result == "error")
                {
                    string operation = Console.ReadLine();
                    int code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation, code));
                }
            }

        }

        static string ShowSuccess(string operation, string message)

        {
            string result = $"Successfully executed { operation }.\n==============================\nMessage: {message}.";
            return result;
        }

        static string ShowError(string operation, int code)

        {
            string reason = "Invalid Client Data";
            if (code<0)
            {
                reason = "Internal System Failure";
            }
            
            string result = $"Error: Failed to execute {operation}.\n==============================\nError Code: {code}.\nReason: {reason}.";
            return result;
        }

    }
}
