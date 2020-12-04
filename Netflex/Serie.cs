namespace Netflex
{
  class Serie : Show
  {
    public Serie(string name) : base(name) { }

    public int Episodes { get; set; }
    public int Seasons { get; set; }
  }
}