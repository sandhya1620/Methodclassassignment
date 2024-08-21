
Copy code
using System;

namespace MathOperationConsoleApp
{
    // Define a class named 'MathOperations'
    public class MathOperations
    {
        // Define a method named 'PerformOperation' that takes two integers as parameters
        public void PerformOperation(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., add 10 to num1)
            int result = num1 + 10;

            // Display the second integer to the console
            Console.WriteLine($"The result of the operation is: {result}");
            Console.WriteLine($"The second integer is: {num2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the MathOperations class
            MathOperations mathOps = new MathOperations();

            // Call the PerformOperation method by passing two numbers positionally
            mathOps.PerformOperation(5, 20);

            // Call the PerformOperation method by specifying the parameters by name
            mathOps.PerformOperation(num1: 15, num2: 30);
        }
    }
}