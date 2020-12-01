using System;

namespace ÖvningsuppgifterDel7
{
  public enum PropertyType
  {
    Townhouse,
    Villa,
    ResidentialComplex,
  }
  class Property
  {
    public int roomsAmount;
    public PropertyType type;
    public int area;
    public int floorsAmount;

    public void Describe() => Console.WriteLine($"{type} \nRooms amount: {roomsAmount}, \nArea: {area}m^3, \nFloors amount: {floorsAmount}");

  }
}