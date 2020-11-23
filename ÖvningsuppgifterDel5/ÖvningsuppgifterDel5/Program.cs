using System;

namespace ÖvningsuppgifterDel5
{
    class Program
    {
        static void Main(string[] args)
        {
            // ex1();

            //int[] arr = SortThreeNumbers(121, 23, 44);
            //foreach (int n in arr)
            //{
            //    Console.Write($"{n} ");
            //}

            //int result = Hexagontal(2);
            //Console.WriteLine(result);

            TriangleNumber(3);
            TriangleNumber(10);
        }

        /*
           1.  Skapa ett program som har en en array eller lista för strängar som du du kalla kompisLista.
           2.  Fyll den med minst tre namn.T.ex.Robin, Björn B, Björn S.
           3.  Skriv en foreach-loop för varje sträng kompis i kompisLista.
           4.  I din loop skriv ut "Hej " + namnet på en kompis så att alla kompisar har blivit hälsade på när loopen körts klart. 
        */
        private static void ex1()
        {
            string[] kompisLista = { "Robin", "Björn B", "Björn C" };
            foreach (string name in kompisLista)
            {
                Console.WriteLine($"Hej {name}");
            }

            for (int i = 0; i < kompisLista.Length; i++)
            {
                Welcome(kompisLista[i]);
            }
        }

        /*
            5.  Skriv en metod static void HälsaPå(string kompis)
            6.  Flytta innehållet i forloop från uppgift 3. till din metod.
            7.  I ditt huvudprogram(Main) gör så att loopen kallar på HälsaPå(kompis) istället för att skriva ut själv.

            Bonusuppgift: För att göra hälsningen lite mindre stel testa att använda Random rnd = new Random(); och en
                string array med olika hälsningsfraser för att blanda vilka fraser du använder för att hälsa på dina kompisar
        */
        private static void Welcome(string name)
        {
            string[] welcomePhrases = { "God dag", "Hejsan", "Tjena", "Välkommen", "Goddag" };
            Random rnd = new Random();
            int number = rnd.Next(0, welcomePhrases.Length);
            Console.WriteLine($"{welcomePhrases[number]} {name}");
        }

        /* 
            8.  Skriv en metod sorteraTreTal som tar tre tal som paramterar och returnerar en array. 
            9.  Skapa en array och placera dina tre tal i storleksordning i arrayen. 
                Du kan återanvända kod från tidigare uppgifter för att ta reda på vilket tal som är stört, mellan och minst. 
            10. Returnera arrayen. 
            11. Testa så att metoden fungerar genom att skriva ut arrayen med hjälp av en foreach-loop i huvudprogrammet. 
         */
        private static int[] SortThreeNumbers(int a, int b, int c)
        {
            int[] arr = { a, b, c };
            Array.Sort(arr);
            return arr;
        }

        /*
             12. Skriv en metod static int Hexagontal som tar en int n som parameter. 
            13. I metoden skapa en variabel för summan och sätt det till 0. 
            14. Skriv en for-loop som går från k = 0 till k < n. 
            15. I loopen öka summan med 4 * k + 1. 
            16. Returnera summan
            17. I huvudprogrammet anropa på metoden och skriv ut returvärdet till konsolen. 
            För att kolla om du gjort rätt så ger n=1 -> 1, n=2 -> 6, n=3 -> 15, n=4 -> 28
        */
        private static int Hexagontal(int n)
        {
            int sum = 0;

            for (int k = 0; k < n; k++)
            {
                sum = sum + 4 * k + 1;
            }

            return sum;
        }


        /*
            Triangeltal är som kan modelleras som trianglar eller trappor. T.ex. 3 = 1 + 2 eller 10 = 1 + 2 + 3 + 4. 
            19. Skapa en metod som givit ett tal testar med hjälp utav en loop ifall det talet är ett triangel tal. 
                Så i det här fallet ska du bruteforca talet på något sätt eftersom det är programmering vi ska öva på och inte matte. 
            20. Om talet är ett triangeltal så ska metoden kalla på en annan metod som skriver ut det i trapform:
                            10
                          6  9
                       3  5  8
                    1  2  3  4
                Dvs varje position i trappan ska skriva ut antalet platser till vänster och under det. 
        */

        private static void TriangleNumber(int n)
        {
            IsNumberTriangel(n);
        }

        private static void IsNumberTriangel(int n)
        {
            int sum = 0;
            int steps = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + i;
                steps++;
                if (sum == n)
                {
                    PrintTrapForm(steps, n);
                };
            }
        }


        private static void PrintTrapForm(int steps, int n)

        {
            int numbers = n;
            for (int i = 1; i <= steps; i++)
            {
                if (numbers > 1)
                {
                    for (int j = 1; j < steps - i; j++)
                    {
                        Console.Write("  ");
                    }
                    for (int k = 1; k <= i; k++)
                    {
                        Console.Write($"{numbers--} ");
                    }
                    Console.WriteLine();

                }
            }

        }
    }
}
