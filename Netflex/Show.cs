using System;

namespace Netflex
{
  class Show
  {
    public Show(string name)
    {
      Name = name;
    }

    public string Name { get; }
    public int Year { get; set; }
    public string Category { get; set; }
    public void Play() { Console.WriteLine($"Playing {Name}"); }
  }
}