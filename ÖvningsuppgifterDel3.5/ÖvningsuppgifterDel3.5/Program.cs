using System;
using System.Linq;

namespace ÖvningsuppgifterDel3._5
{
    class Program
    {  
       //20. Skapa ett program som ber användaren mata in en sträng.
       //21. Loopa över varje char i strängen och om tecknet är en konsonant.
       //Skriv ut konsonanten följt av ett o och sedan kononanten igen.
       //Annars skriv bara ut tecknet.
        static void Main(string[] args)
        {
            Console.Write("Write a string: ");
            string text = Console.ReadLine();
            char[] vowels = new char[] {'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
            for(int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]) && Char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                } else if(!vowels.Contains(text[i]) && Char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                    Console.Write('o');
                    Console.Write(Char.ToLower(text[i]));
                } else
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
