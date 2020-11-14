using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class BasicAlgorithm
    {
         public void Exercise4()
        {
            Console.WriteLine("Check a given integer and return true if it is within 10 of 100 or 200");
            Console.WriteLine("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(checkNumber(number));

        }

        private static bool checkNumber(int number)
        {
            if (Math.Abs(number - 100) <= 10 || Math.Abs(number - 200) <= 10)
                return true;
            return false;
        }
    }
}
