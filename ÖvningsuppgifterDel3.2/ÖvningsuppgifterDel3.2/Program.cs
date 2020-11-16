using System;
using System.Collections.Generic;

namespace ÖvningsuppgifterDel3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.Skapa ett program som innehåller en lista för strängar.
            //7.Lägg till en bool keepGoing som du sätter till false.
            //8.Skriv en do -while loop som har keepGoing booleanen som villkor. 
            //9.Be användaren mata in en namn i do -while loopen.
            //10.Om användarens inmatning är en tom sträng(antingen genom att kolla om strängens längd är noll eller genom att kolla om den är lika med "") sätt sätt keepGoing till false
            //11.Annars sätt keepGoing till true och spara namnet till listan.
            //12.Skriv ut listan med namn. 

            List<string> strings = new List<string>();
            bool keepGoing = false;

            do
            {
                Console.WriteLine("mata in en namn");
                string name = Console.ReadLine();

                if(name == "")
                {
                    keepGoing = false;
                } else
                {
                    strings.Add(name + ", ");
                    keepGoing = true;
                }
            } while (keepGoing);


            Console.WriteLine(string.Join(' ', strings));
        }
    }
}
