using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class Functions
    {
        public void Exercise6()
        {
            Console.WriteLine("Write a program in C# Sharp to create a function to swap the values of two integer numbers.");
            Console.Write("First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"First: {firstNumber}, Second: {secondNumber}");
            Console.WriteLine("Swaping ...");
            
            // The ref keyword indicates a value that is passed by reference.
            // read more https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
            swapNumbers(ref firstNumber, ref secondNumber);

            Console.WriteLine($"First: {firstNumber}, Second: {secondNumber}");
        }

        private void swapNumbers(ref int firstNumber, ref int secondNumber)
        {
            (firstNumber, secondNumber) = (secondNumber, firstNumber);
        }

        public void Exercise7()
        {

        }
    }
}
