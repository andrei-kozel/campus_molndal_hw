using System;
using System.Collections.Generic;

namespace Netflex
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Serie> listOfSeries = new List<Serie>();
      List<Movie> listOfMovies = new List<Movie>();

      Console.WriteLine("Välkommen till Netflex");
      Console.WriteLine("Välja något av följande alternativ att skapa");
      Console.WriteLine("1. Serier");
      Console.WriteLine("2. Filmer");
      Console.WriteLine("3. Gå vidare");
      string answer = Console.ReadLine();
      bool shouldContinue = true;
      switch (answer)
      {
        case "1":
          while (shouldContinue)
          {
            Serie serie = CreateSerie();
            listOfSeries.Add(serie);
            shouldContinue = AskAgain("serie");
          }
          break;
        case "2":
          while (shouldContinue)
          {
            Movie movie = CreateMovie();
            listOfMovies.Add(movie);
            shouldContinue = AskAgain("film");
          }
          break;
        case "3":
          break;
      }
      Console.WriteLine("Vad vill du titta på?");
      Console.WriteLine("1. Visa alla Serier");
      Console.WriteLine("2. Visa alla Filmer");
      answer = Console.ReadLine();
      switch (answer)
      {
        case "1":
          PrintAll(listOfSeries);
          break;
        case "2":
          PrintAll(listOfMovies);
          break;
      }
    }

    private static bool AskAgain(string s)
    {
      Console.WriteLine($"Vill du skapa en till {s}? Y/N");
      string answer = Console.ReadLine().ToLower();
      return answer == "y" ? true : false;
    }

    private static void PrintAll(List<Movie> listOfMovies)
    {
      Console.Clear();
      int index = 1;
      foreach (Movie movie in listOfMovies)
      {
        Console.WriteLine($"{index}. {movie.Name}");
        index++;
      }
    }

    private static void PrintAll(List<Serie> listOfSeries)
    {
      Console.Clear();
      int index = 1;
      foreach (Serie serie in listOfSeries)
      {
        Console.WriteLine($"{index}. {serie.Name}");
        index++;
      }
    }

    private static Serie CreateSerie()
    {
      Console.Write("Namn: ");
      string name = Console.ReadLine();
      Console.Write("Årtal (yyyy): ");
      int year = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Kategori ex: [Horror, Comedy, Action, Reality]");
      Console.Write("Kategori: ");
      string category = Console.ReadLine();
      Console.Write("Antal säsonger: ");
      int seasons = Convert.ToInt32(Console.ReadLine());
      Console.Write("Antal avsnitt i varje säsong: ");
      int episodes = Convert.ToInt32(Console.ReadLine());
      Serie serie = new Serie(name);
      serie.Year = year;
      serie.Category = category;
      serie.Episodes = episodes;
      serie.Seasons = seasons;
      return serie;
    }

    private static Movie CreateMovie()
    {
      Console.Write("Namn: ");
      string name = Console.ReadLine();
      Console.Write("Årtal (yyyy): ");
      int year = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Kategori ex: [Horror, Comedy, Action, Reality]");
      Console.Write("Kategori: ");
      string category = Console.ReadLine();
      Console.Write("Längd (minuter): ");
      int length = Convert.ToInt32(Console.ReadLine());
      Movie movie = new Movie(name);
      movie.Year = year;
      movie.Category = category;
      movie.Length = length;
      return movie;
    }
  }
}
