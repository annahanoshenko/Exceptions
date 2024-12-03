using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the first number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Choose operation (+, -, *, /): ");
                string operation = Console.ReadLine();

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
                            throw new DivideByZeroException("Divede by thero is impossible.");
                        result = num1 / num2;
                        break;
                    default:
                        throw new InvalidOperationException("Operation is not supported.");
                }

                Console.WriteLine($"Result: {result}");

            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            finally
            {
                Console.WriteLine("Thanks for using calculator!");
            }
            Console.ReadKey();
        }
    }
}

