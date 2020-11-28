using System;
using System.Collections.Generic;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();
            var completedTask = new List<string>();
            Welcome();
            while (true) Menu(tasks, completedTask);
        }

        static private void Welcome()
        {
            Console.WriteLine("Välkomen till Att-Göra-Lista");
        }

        static private void AddTasks(List<string> tasks)
        {
            Console.Clear();
            Console.WriteLine("Lägg en uppgift taget, (skriv 'q' för att avsluta)");
            bool isRunning = true;
            while (isRunning)
            {
                Console.Write("Uppgift: ");
                string task = Console.ReadLine();
                if (task.ToLower() == "q") isRunning = false;
                tasks.Add(task);
            }
        }

        static private void ShowTasks(List<string> tasks)
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            Console.WriteLine("---------------------------");
        }

        static private void CompleteTask(List<string> tasks, List<string> completedTasks)
        {
            Console.Clear();
            Console.WriteLine("Välj uppgift som är utförd. (skriv 'q' för att avsluta)");
            ShowTasks(tasks);
            Console.Write("Färdig med: ");
            string response = Console.ReadLine();
            if (response.ToLower() != "q")
            {
                completedTasks.Add(tasks[Convert.ToInt32(response) - 1]);
                tasks.Remove(tasks[Convert.ToInt32(response) - 1]);
            };
        }

        static private void DeleteTask(List<string> tasks)
        {
            Console.Clear();
            Console.WriteLine("Välj uppgift som du vill ta bort. (skriv 'q' för att avsluta)");
            ShowTasks(tasks);
            Console.Write("Färdig med: ");
            string response = Console.ReadLine();
            if (response.ToLower() != "q")
            {
                tasks.Remove(tasks[Convert.ToInt32(response) - 1]);
            };
        }

        static private void Menu(List<string> tasks, List<string> completedTasks)
        {
            Console.WriteLine();
            Console.WriteLine("Välj något av följande alternativ:");
            Console.WriteLine("1. Lägg till.");
            Console.WriteLine("2. Visa uppgifter.");
            Console.WriteLine("3. Klarmarkera.");
            Console.WriteLine("4. Visa avklarade.");
            Console.WriteLine("5. Ta bort.");
            Console.WriteLine("q. Avsluta");

            string response = Console.ReadLine();

            if (response == "1") AddTasks(tasks);
            else if (response == "2") ShowTasks(tasks);
            else if (response == "3") CompleteTask(tasks, completedTasks);
            else if (response == "4") ShowTasks(completedTasks);
            else if (response == "5") DeleteTask(tasks);

        }
    }
}
