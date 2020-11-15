using System;
using System.Collections.Generic;
using System.Text;

namespace w3resource
{
    class DataTypes
    {
        public void Exercise1()
        {
            Console.WriteLine("Write a C# program that takes three letters as input and display them in reverse order");

            Console.Write("Input the First Letter : ");
            string a =(Console.ReadLine());
            Console.Write("Input the Second Letter : ");
            string b = (Console.ReadLine());
            Console.Write("input the Third Letter : ");
            string c = (Console.ReadLine());

            Console.WriteLine($"{c}, {b}, {a}");
        }



        public void Exercise3()
        {
            Console.WriteLine("Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts, user will be rejected. ");
            Console.Write("You UserID : ");
            string id = Console.ReadLine();
            Console.Write("Your Password : ");
            string password = Console.ReadLine();
            Console.WriteLine("Let's try to Log you In");
            int tries = 0;
            while(tries < 3)
            {
                Console.Write("UserID : ");
                string logInId = Console.ReadLine();
                Console.Write("Password : ");
                string logInPassword = Console.ReadLine();
                if (logInId == id && logInPassword == password)
                {
                    Console.WriteLine("Nice!");
                    break;
                }
                else
                {
                    tries++;
                    Console.WriteLine("Something is wrong");
                    Console.WriteLine($"You can try {3 - tries} more times");
                }
            }
            if(tries == 3)
            {
                Console.WriteLine("end");
            }
        }

        public void Exercise9()
        {

        }

        public void Exercise11()
        {

        }
    }
}
