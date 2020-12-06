using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningsuppgifterDel8
{
    class Human
    {
        private string name;
        private int age;
        private int length;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }   
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public virtual void Describe()
        {
            Console.WriteLine($"Jag heter {Name}");
            Console.WriteLine($"Jag är {Age} år gammal");
            Console.WriteLine($"Jag är {Length}cm lång");
        }

    }

    class Teacher : Human
    {
        private Kurs kurs;

        public Kurs Course
        {
            get { return kurs; }
            set { kurs = value; }
        }

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Jag undervisar {kurs.Amount} i kursen {kurs.Name}");
        }
    }

    class Student : Human
    {
        private Kurs kurs;
        public Kurs Course
        {
            get { return kurs; }
            set { kurs = value; }
        }
        public override void Describe()
        {
            base.Describe();
            Console.WriteLine($"Jag läser: {kurs.Name}"); 
        }
    }
}
