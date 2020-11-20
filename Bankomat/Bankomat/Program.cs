using System;
using System.Collections.Generic;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            string mainPin = "1234";
            double balance = 100;
            bool isAccessAllowed = false;
            List<double> history = new List<double>();
            Console.WriteLine("Welcome to the bank of Zeros and Ones");
            Console.Write("Enter your pin, 4 or 6 digits: ");
            string pin = Console.ReadLine();
            if (pin != mainPin || pin.Length < 4 || pin.Length > 6)
            {
                Console.WriteLine("Invalid pin");
            }
            else
            {
                isAccessAllowed = true;
            }

            if (isAccessAllowed)
            {
                Console.WriteLine("Valid pin. Welcome human!");
                while (isAccessAllowed)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("----------------------------");
                    Console.WriteLine("1. Deposit Money.");
                    Console.WriteLine("2. Withdraw money.");
                    Console.WriteLine("3. Check Balance.");
                    Console.WriteLine("4. Collect Interest");
                    Console.WriteLine("5. End.");
                    Console.WriteLine("----------------------------");
                    string answer = Console.ReadLine();

                    if (answer == "1")
                    {
                        Console.WriteLine("How much do you want to deposit?");
                        Console.Write("Amount: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        balance = balance + amount;
                        Console.WriteLine($"Current balance is {balance}");
                        history.Add(balance);
                    }
                    if (answer == "2")
                    {
                        Console.WriteLine("How much do you want to withdraw?");
                        Console.Write("Amount: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        balance = balance - amount;
                        Console.WriteLine($"Current balance is {balance}");
                        history.Add(balance);

                    }
                    if (answer == "3")
                    {
                        Console.WriteLine($"Current balance is {balance}");
                    }
                    if (answer == "4")
                    {
                        Console.WriteLine("How naby years do you want to skip?");
                        int years = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < years; i++)
                        {
                            if (balance <= 1000)
                                balance = balance * 2;
                            else if (balance > 1000 && balance <= 5000)
                                balance = balance * 3;
                            else if (balance > 5000 && balance <= 10000)
                                balance = balance * 5;
                        }
                        Console.WriteLine($"You have now skipped {years} and your new balance is {balance}");
                        history.Add(balance);

                    }
                    if (answer == "5")
                    {
                        isAccessAllowed = false;
                        Console.WriteLine("Bye");
                    }

                }

            }

            history.ForEach(h => Console.WriteLine(h));
        }
    }
}
