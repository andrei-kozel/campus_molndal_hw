using System;

namespace ÖvningsuppgifterDel8
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs = new Kurs();
            //kurs.Amount = -14;
            //kurs.Name = "Objektorienterad programmering i C# v1";
            //Console.WriteLine(kurs.Name);
            //Console.WriteLine(kurs.Amount);
            kurs.Amount = 36;
            kurs.Name = "Objektorienterad programmering i C#";
            Console.WriteLine("----------COURSE-----------");
            Console.WriteLine(kurs.Name);
            Console.WriteLine(kurs.Amount);

            
            Teacher t = new Teacher();
            t.Name = "Robin";
            t.Age = 30;
            t.Length = 190;
            t.Course = kurs;
            Console.WriteLine();
            Console.WriteLine("----------TEACHER-----------");
            t.Describe();

            Student s = new Student();
            s.Name = "Andrei";
            s.Age = 27;
            s.Course = kurs;
            Console.WriteLine();
            Console.WriteLine("----------STUDENT-----------");
            s.Describe();
        }
    }
}
