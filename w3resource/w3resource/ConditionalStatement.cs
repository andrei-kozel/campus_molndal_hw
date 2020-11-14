using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class ConditionalStatement
    {
        public void Exercise1()
        {
            Console.WriteLine("Write a C# Sharp program to accept two integers and check whether they are equal or not.");
            Console.Write("First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b) {
                Console.WriteLine($"{a} and {b} are equals");
            } else
            {
                Console.WriteLine($"{a} and {b} are not equals");
            }
        }

        public void Exercise7()
        {
            Console.WriteLine("Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. ");
            Console.Write("The height of a person: ");
            int height = Convert.ToInt32(Console.ReadLine());
            if(height < 150)
            {
                Console.WriteLine("The person is Dwarf");
            } else if ( height < 190)
            {
                Console.WriteLine("The person is Human");
            } else
            {
                Console.WriteLine("The person is Elf");
            }
         }

        public void Exercise8()
        {
        }
    }
}
