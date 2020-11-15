using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class Recursion
    {
        public void Exercise1()
        {
            Console.WriteLine("Write a program in C# to print the first n natural number using recursion.");
            int input = Convert.ToInt32(Console.ReadLine());
            PrintNaturalNumebers(input, 1);
        }

        public static int PrintNaturalNumebers(int n, int start)
        {   
            if(n < start) return n;
            Console.Write($"{start} ");
            return PrintNaturalNumebers(n, start + 1);
        }

        public void Exercise10()
        {
            Console.WriteLine("Write a program in C# to find the Fibonacci numbers for a n numbers of series using recursion.");
            int input = Convert.ToInt32(Console.ReadLine());
            Fibonacci(0, 1, 1, input);
        }

        public static void Fibonacci(int a, int b, int counter, int number)
        {
            Console.Write($"{a} ");
            if(counter < number) Fibonacci(b, b+a, counter + 1, number);
        }

        public void Exercise13()
        {

        }

        public void Exercise15()
        {

        }
    }
}
