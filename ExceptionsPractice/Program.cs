using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsPractice
{
    public class CustomException : Exception
    {
        public CustomException(string massege) : base(massege) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new CustomException("This is a custom exception.");
            }
                catch(CustomException ex)
                {
                    Console.WriteLine($"Custom error: {ex.Message}");
                }

            try
            {
                throw new Exception("Smth went wrong.");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            try
            {
                int[] numbers = { 1, 2, 3 };
                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                string contetnt = File.ReadAllText("nonexistent.txt");
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                int number = int.Parse("abc");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                throw new Exception("Er");
            }
            catch (Exception ex) when (ex.Message.Contains("Error"))
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            try
            {
                throw new InvalidOperationException("Custom message");
            }
            catch (InvalidOperationException ex) when (ex.Message.Contains("Custom"))
            {
                Console.WriteLine("Caught specific InvalidOperationException with 'Custom' in the message.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Caught a general exception: {ex.Message}");
            }

            bool isDebugMode = true;

            try
            {
                int sec = 0;
                int result = 10 / sec;
            }
            catch (DivideByZeroException ex) when (isDebugMode)
            {
                Console.WriteLine("Debug mode: Divide by zero detected.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Production mode: Please contact support.");
            }

            try
            {
                throw new ArgumentException("Parameter cannot be null or empty", "parameterName");
            }
            catch(ArgumentException ex) when (ex.ParamName == "parameterName")
            {
                Console.WriteLine("Caught an ArgumentException for 'parameterName'.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Caught an ArgumentException for another parameter.");
            }
        }
    }
}
