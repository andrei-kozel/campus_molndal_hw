using System;

namespace ÖvningsuppgifterDel7
{
  class Program
  {
    static void Main(string[] args)
    {
      //   TransportHW();
      PropertyHW();
    }

    private static void PropertyHW()
    {
      var villa = new Property
      {
        area = 72,
        floorsAmount = 2,
        roomsAmount = 4,
        type = PropertyType.Villa
      };
      villa.Describe();
      Console.WriteLine("------------------------------");

      var townhouse = new Property
      {
        area = 100,
        floorsAmount = 3,
        roomsAmount = 12,
        type = PropertyType.Townhouse
      };
      townhouse.Describe();
      Console.WriteLine("------------------------------");

      var residentialComplex = new Property
      {
        area = 42,
        floorsAmount = 1,
        roomsAmount = 2,
        type = PropertyType.ResidentialComplex
      };
      residentialComplex.Describe();
      Console.WriteLine("------------------------------");
    }

    private static void TransportHW()
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

}
