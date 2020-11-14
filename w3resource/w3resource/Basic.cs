using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class Basic
    {
        public void Exercise1()
        {
            Console.WriteLine("Hello Andrei");
        }

        public void Exercise4()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        public void Exercise5()
        {
            Console.Write("Input the First Number : ");
            string firstNumber = Console.ReadLine();
            Console.Write("Input the Second Number : ");
            string secondNumber = Console.ReadLine();
            Console.WriteLine($"First Number : {firstNumber}");
            Console.WriteLine($"Second Number : {secondNumber}");
        }

        public void Exercise6()
        {
            Console.Write("Input the First Number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Second Number : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("input the Third Number : ");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine($"{a} + {b} + {c} = " + sum);
        }

        public void Exercise7()
        {
            Console.Write("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int sub = a - b;
            int mult = a * b;
            double div = Convert.ToDouble(a) / Convert.ToDouble(b);
            int mod = a % b;
            Console.WriteLine($"{a} + {b} = " + sum);
            Console.WriteLine($"{a} - {b} = " + sub);
            Console.WriteLine($"{a} * {b} = " + mult);
            Console.WriteLine($"{a} / {b} = " + div);
            Console.WriteLine($"{a} % {b} = " + mod);
        }

        public void Exercise14()
        {
            Console.Write("Enter the amount of celsius : ");
            int celsius = Convert.ToInt32(Console.ReadLine());
            double kelvin = Convert.ToDouble(celsius) * 1.8000 + 32;
            double fahrenheit = Convert.ToDouble(celsius) + 273.15;
            Console.WriteLine("Kelvin = " + kelvin);
            Console.WriteLine("Fahrenheit = " + fahrenheit);
        }
        public void Exercise16()
        {
            Console.Write("Input the word: ");
            string word = Console.ReadLine();
            string slicedWord = word.Substring(1, word.Length - 2);
            Console.WriteLine(word.Substring(word.Length - 1) + slicedWord + word.Substring(0, 1));
        }

        public void Exercise23()
        {
            Console.Write("Give me a String : ");
            string text = Console.ReadLine();
            Console.WriteLine($"CapsLock mode on: {text.ToUpper()}");
            Console.WriteLine($"CapsLock mode off: {text.ToLower()}");
        }

        public void Exercise30()
        {
            string hexValue = "4B0";
            Console.WriteLine($"Hexadecimal number: {hexValue}");
            Console.WriteLine("Converting to decimal");
            int number = Convert.ToInt32(hexValue, 16);
            Console.WriteLine($"Decimal number: {number}");
        }

        public void Exercise33()
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num % 7 == 0 || num % 3 == 0);
        }
    }
}
