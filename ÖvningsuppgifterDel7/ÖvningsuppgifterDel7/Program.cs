using System;

namespace ÖvningsuppgifterDel7
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport Plane = new Transport
            {
                title = "Dassault Falcon 8X",
                yearOfIssue = 2018,
                color = "White",
                type = "Air",
                gas = "Jet fuel",
                avgPrice = 43_900_000,
                speed = 953,
                amountPassangers = 22
            };
            Plane.Describe();
            Plane.GoForward("fly");
            Console.WriteLine("------------------------------");

            Transport Tank = new Transport
            {
                title = "T-34",
                yearOfIssue = 1937,
                color = "Military",
                type = "Medium tank",
                gas = "Diesel",
                avgPrice = 218603,
                speed = 53,
                amountPassangers = 4
            };
            Tank.Describe();
            Tank.GoForward("drive");
            Console.WriteLine("------------------------------");

            Transport ElectricalScooter = new Transport
            {
                title = "xiaomi mi pro 2",
                yearOfIssue = 1937,
                color = "Black",
                type = "Scooter",
                gas = "Electical",
                avgPrice = 650,
                speed = 25,
                amountPassangers = 1
            };
            ElectricalScooter.Describe();
            ElectricalScooter.GoForward("go");
            Console.WriteLine("------------------------------");

        }
    }

    class Transport
    {
        public string title;
        public int yearOfIssue;
        public string color;
        public string type;
        public string gas;
        public int avgPrice;
        public int speed;
        public int amountPassangers;

        public void Describe() => Console.WriteLine($"Title: {title}, \nYear of issue: {yearOfIssue}, \nType: {type}, \nColor: {color}, \nGas: {gas}, \nAverage price: {avgPrice}$, \nSpeed: {speed}kmh, \nPassengers amount: {amountPassangers}");

        public void GoForward(string s) => Console.WriteLine($"Let's {s}.");

    }

}
