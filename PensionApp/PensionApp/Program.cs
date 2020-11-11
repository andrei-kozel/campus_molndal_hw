using System;

namespace PensionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej. Hur gammal är du?");
            int age  = Convert.ToInt32(Console.ReadLine());
            int storedAge = age;
            int retirementAge = 66;
            int yearsToRetierment = retirementAge - age;

            Console.WriteLine($"Du har {yearsToRetierment} år till pension");

            Console.WriteLine("Vill du spola fram tiden till pension? Svara [Ja] eller [Nej]:");

            string answer = Console.ReadLine();
            
            if(answer.ToLower() == "ja")
            {
                while(age <= 65)
                {
                    Console.WriteLine($"Ok. Spolar till {age} år");
                    age++;
                }

                Console.WriteLine($"Du är {age}.");
                Console.WriteLine("1. Jag vill stanna på denna ålder");
                Console.WriteLine("2. Ta mig tillbaka!");
                int answer2 = Convert.ToInt32(Console.ReadLine());

                while (answer2 > 2)
                {
                    Console.WriteLine("Du skrev fel nummer. Testa igen!");
                    Console.WriteLine("1. Jag vill stanna på denna ålder");
                    Console.WriteLine("2. Ta mig tillbaka!");
                    answer2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(answer2);
                }

                if (answer2 == 1)
                {
                    Console.WriteLine("Du är pensionär.");
                }
                if (answer2 == 2)
                {
                    while (age != storedAge )
                    {
                        age--;
                        Console.WriteLine($"Du har {age} år gammal");
                    }
                }
            } else
            {
                Console.WriteLine("Okej.");
            }

            

            Console.WriteLine("Välkommen tillbaka!");

        }
    }
}
