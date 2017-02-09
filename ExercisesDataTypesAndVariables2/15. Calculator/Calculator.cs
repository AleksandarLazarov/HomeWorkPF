using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        string znak = Console.ReadLine();
        int num2 = int.Parse(Console.ReadLine());

        switch (znak)
        {
            case "+":
                Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                break;
            case "-":
                Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                break;
            case "*":
                Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                break;
            case "/":
                Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                break;

        }




    }
}
