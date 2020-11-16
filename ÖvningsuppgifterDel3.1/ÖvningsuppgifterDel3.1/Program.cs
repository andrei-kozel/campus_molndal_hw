using System;

namespace ÖvningsuppgifterDel3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 10 };
            int i = 0;
            while(i < arr.Length)
            {
                Console.Write($"{arr[i]} ");
                i++;
            }
        }
    }
}
