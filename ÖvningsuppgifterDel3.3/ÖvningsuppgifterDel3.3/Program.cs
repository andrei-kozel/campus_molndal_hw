using System;

namespace ÖvningsuppgifterDel3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //13.Skapa en programm som frågar användaren efter ett heltal. 
            //14.Skriv sedan en loop sprarar det talets gångentabell(1 till 10) i en array.
            //15.Skriv sedan ut arrayen till consollen.

            Console.WriteLine("frågar användaren efter ett heltal");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int index = 0;
            for(int i = 1; i <= 10; i++)
            {
                arr[index] = num * i;
                index++;
            }
            index = 0;
            while(index < arr.Length)
            {
                Console.Write($"{arr[index]} ");
                index++;
            }

        }
    }
}
