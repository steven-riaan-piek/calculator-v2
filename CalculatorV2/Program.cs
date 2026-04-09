using System;
using System.Security.Cryptography;

class Program
{
    //I enhanced my calculator by adding a loop for continuous use, switch-case logic for cleaner structure,
    //modulus support, and error handling to prevent crashes from invalid input or division by zero.
    static void Main()
    {
        Console.WriteLine("=== Advanced Calculator(V2) ===");

        while (true)
        {
         
            try
            {
                
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                
                Console.Write("Choose operation (+, -, *, /, %(modulus)) or 'q' to quit: ");
                string operation = Console.ReadLine();

                if (operation.ToLower() == "q")
                {
                    Console.WriteLine("Goodbye!");
                    break; 
                }

                double result;

               
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;

                    case "-":
                        result = num1 - num2;
                        break;

                    case "*":
                        result = num1 * num2;
                        break;

                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            continue; 
                        }
                        result = num1 / num2;
                        break;

                    case "%":
                        result = num1 % num2;
                        break;

                    default:
                        Console.WriteLine("Invalid operation!");
                        continue;
                }

                Console.WriteLine("Result: " + result);
            }
            catch
            {
               
                Console.WriteLine("Invalid input! Please enter numbers only.");
            }
            
            Console.Write("\nDo you want to continue? (y/n): ");
            string choice = Console.ReadLine().Trim().ToLower(); 

            
            if (string.IsNullOrEmpty(choice) || !choice.StartsWith("y"))
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.Clear();
            Console.WriteLine(); 
        }
    }
}