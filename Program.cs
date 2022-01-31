using System;

namespace Learn
{
    class Program
    {
        static void Main(string[] args)
        {

        Calc:

            //Catching the error cause by invalid format
            try
            {
                float result;
                Console.WriteLine("Enter a number: ");
                float a = float.Parse(Console.ReadLine()); //Get user input 
                Console.WriteLine("Enter another number: ");
                float b = float.Parse(Console.ReadLine()); // Get user input
                Console.WriteLine("Enter an option: "); // Get user input
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t-: Subtract/Minus");
                Console.WriteLine("\t* : Times/Multiply");
                Console.WriteLine("\t/ : Divide");

                switch (Console.ReadLine()) // List of cases where the users can use
                {
                    case "+":
                        result = a + b;
                        Console.WriteLine("Result: " + result); //For adding
                        break;
                    case "-":
                        result = a - b;
                        Console.WriteLine("Result: " + result); //For subtracting
                        break;
                    case "*":
                        result = a * b;
                        Console.WriteLine("Result: " + result); //For multiplying
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Cannot divide by 0 (or it's equal infinity)");
                            // Catching the error cause by divide by 0
                        }
                        else
                        {
                            result = a / b;
                            Console.WriteLine("Result: " + result); //For dividing
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter +, -, / or *"); // Catching the invalid format for option
                        break;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter in correct format, please. You may include the dot."); //Catching the error cause by invalid format
            }
            Console.WriteLine();
            goto Calc; // You can replace with while or for loops. I use this because i'm lazy 
        }
    }
}
