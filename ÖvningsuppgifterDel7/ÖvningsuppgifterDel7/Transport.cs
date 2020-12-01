using System;

namespace ÖvningsuppgifterDel7
{
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