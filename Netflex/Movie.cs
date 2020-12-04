namespace Netflex
{
  class Movie : Show
  {
    public Movie(string name) : base(name)
    {
    }
    public int Length { get; set; }
  }
}