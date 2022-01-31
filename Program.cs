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
                double result;
                Console.WriteLine("Enter a number: ");
                double a = Convert.ToDouble(Console.ReadLine()); //Get user input 
                Console.WriteLine("Enter another number: ");
                double b = Convert.ToDouble(Console.ReadLine()); // Get user input
                Console.WriteLine("Enter an option: "); // Get user input
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t-: Subtract/Minus");
                Console.WriteLine("\t* : Times/Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\t^ : Power");
                Console.WriteLine("\tExtra: hypo : Hypotenuse");

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
                    case "^":
                        result = Math.Pow(a, b);
                        Console.WriteLine("Result: " + result); //For multiplying
                        break;
                    case "hypo":
                        result = Math.Sqrt((a * a) + (b * b));
                        Console.WriteLine("Result: " + result); //For multiplying
                        break;

                    default:
                        Console.WriteLine("Please enter +, -, /, *, sqrt"); // Catching the invalid format for option
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
