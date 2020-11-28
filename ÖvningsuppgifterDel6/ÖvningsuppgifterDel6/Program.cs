using System;
using System.Collections.Generic;

namespace ÖvningsuppgifterDel6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            int a = 10;
            int b = 2;
            double result;
            result = Addition(a, b);
            Console.WriteLine($"Addition({a}, {b}): {result}");
            result = Subtraction(a, b);
            Console.WriteLine($"Subtraction({a}, {b}): {result}");
            result = Division(a, b);
            Console.WriteLine($"Division({a}, {b}): {result}");
            result = Multiplication(a, b);
            Console.WriteLine($"Multiplication({a}, {b}): {result}");
            */

            // 6
            // Console.WriteLine(TriangelArea(10, 2));

            // 7
            // Console.WriteLine(TrueToFalse(false));

            // 8
            // List<int> l = new List<int>{ 1, 4, 7,8,9,44};
            // Console.WriteLine(GetLastElement(l));

            // 9
            // Console.WriteLine(MultiplyBy10(10));

            // 10. Skapa en lista av strings med fyra element "Det" "var" "en" "gång..."
            // List<string> text = new List<string> { "Det", "var", "en", "gång..." };

            // 11. Ta listan av strings och skicka in den i en kedja av metoder.
            // AddString(text);

            // 14. Skapa ett program som ber användaren mata in ett tal 10 gånger.Spara undan dessa i en lista
            // List<int> numbers = EnterNumbers();
            // List<int> odd = new List<int>();
            // List<int> even = new List<int>();

            // 15. Skicka in listan i en metod som heter SortEven.
            // SortEven(numbers, odd, even);
            // 16. För varje element i listan: Kolla om talet är jämt
            // 17. Om talet är jämt skicka in talet till en annan metod som lägger till det i en lista.
            // 18. Gör likadant med ojämna tal
            // 19. Skriv sedan ut de båda listorna med antalet jämna och ojämna tal
            // PrintList(odd, "Odd: ");
            // PrintList(even, "Even: ");

            // 20.Skriv en metod som tar konvertrar timmar till minuter
            // 21.Använd sedan minuterna som argument till en annan metod som konverterar minuter till sekunder.
            // 22.Skriv sedan ut vad timmar blir i minuter och hur många sekunder det är totalt
            //int h = 10;
            //int minutes = ConvertToMin(h);
            //int sec = ConvertToSec(minutes);

            //Console.WriteLine($"{h}h = {minutes}m = {sec}s");

            // 23.Hur mycket är sant? Skriv en metod som kollar en array av bool statements och retunera antalet true / false
            // 24.Om antalet true är mer än false skriv ut "In wine there is potatos!" annars skriv ut "lies lies lies..."
            bool[] b =new bool[]{ false, true, true, true };
            (int countTrue, int countFalse) = CountBools(b);
            if (countTrue > countFalse) Console.WriteLine("In wine there is potatos!");
            else Console.WriteLine("lies lies lies...");

        }

        // 1.Skapa en metod som tar in två argument, int a, int b och returnera a + b
        private static int Addition(int a, int b) => a + b;

        // 2.Skapa en metod som tar in två argument, int a, int b och returnera a - b
        private static int Subtraction(int a, int b) => a - b;

        // 3.Skapa en metod som tar in två argument, int a, int b och returnera a / b
        private static double Division(int a, int b) => a / b;

        // 4.Skapa en metod som tar in två argument, int a, int b och returnera a* b
        private static int Multiplication(int a, int b) => a * b;

        // 6.Skapa en metod som tar in basen och höjden av en triangel och returnera arean
        private static double TriangelArea(int baseSide, int height) => baseSide * height / 2;
       
        // 7.Skapa en metod som tar in en bool och returnera det motsatta
        private static bool TrueToFalse(bool e) => !e;

        // 8.Skapa en metod som tar in en lista och returnerar det sista elementet
        private static int GetLastElement(List<int> numbers) => numbers[numbers.Count - 1];

        // 9.Skapa en metod som tar in ett heltal och multiplicera talet med 10.
        // Kalla sedan på en annan metod från första metoden och returnera det talet delat på 5
        private static double MultiplyBy10(int n) => Division(Multiplication(n, 10), 5);

        // 12. För varje metod lägg till en string i listan
        private static void AddString(List<string> text) 
        {
            text.Add("AddString");
            AddString2(text);   
        }
        private static void AddString2(List<string> text)
        {
            text.Add("AddString");
            AddString3(text);
        }
        // 13. När det finns 10(5) element i listan, skriv ut allt på en rad separerat med,
        private static void AddString3(List<string> text)
        {
            foreach (string s in text) Console.Write($"{s}, ");
        }

        
        private static List<int> EnterNumbers()
        {
            List<int> numbers = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a number {i + 1}: ");
                int n = Convert.ToInt32(Console.ReadLine());
                numbers.Add(n);
            }
            return numbers;
        }


        private static void SortEven(List<int> numbers, List<int> odd, List<int> even)
        {
            foreach(int n in numbers)
            {
                if(n % 2 != 0)
                {
                    AddOdd(odd, n);
                } else {
                    AddEven(even, n);
                }
            }
        }

        private static void AddEven(List<int> even, int n) => even.Add(n);
        private static void AddOdd(List<int> odd, int n) => odd.Add(n);


        private static void PrintList(List<int> even, string v)
        {
            Console.Write(v);
            foreach (int n in even) Console.Write($"[{n}] ");
            Console.WriteLine();
        }

        private static int ConvertToMin(int h) => h * 60;
        private static int ConvertToSec(int minutes) => minutes * 60;

        private static (int countTrue, int countFalse) CountBools(bool[] b)
        {
            int t = 0;
            int f = 0;
            foreach(bool item in b)
            {
                if (item == true) t++;
                else f++;
            }
            return (t, f);
        }
    }
}
