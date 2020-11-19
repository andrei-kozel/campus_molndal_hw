using System;

namespace ÖvningsuppgifterDel3._4
{
    class Program
    {   
        //16. Skapa ett program som ber användaren mata in sitt namn.
        //17. Använd sedan en loop för att spara namnet baklänges i en lista. 
        //18. Se till så att första bokstaven i det nya namnet är storbokstav och de andra bokstäverna är små. 
        //19. Skriv ut det nya namnet.
        //Exempel: Robin blir Nibor
        //https://knowyourmeme.com/memes/write-your-name-in-reverse-its-your-demon-name 

        static void Main(string[] args)
        {
            Console.Write("Write Your Name: ");
            string name = Console.ReadLine();

            for (int i = name.Length; i > 0 ; i--)

            {
                if (i == name.Length)
                    Console.Write(Char.ToUpper(name[i-1]));
                Console.Write(Char.ToLower(name[i - 1]));
            }
        }
    }
}
