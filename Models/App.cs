using System;
using System.Collections.Generic;
using Golf.Interfaces;
using Golf.Models;

namespace Golf
{
  public class App : IApp
  {
    public Course ActiveCourse { get; set; }
    public List<Player> Players { get; set; }
    public List<Course> Courses { get; set; }
    public App()
    {
      Courses = new List<Course>();
      Players = new List<Player>();
    }
    public void Setup()
    {
      Course warmSprings = new Course("Warm Springs");
      Course quailHollow = new Course("Quail Hollow");
      Course indianLakes = new Course("Indian Lakes");

      Hole a = new Hole(3, 2);
      Hole b = new Hole(4, 2);
      Hole c = new Hole(5, 2);

      warmSprings.Holes.Add(a);
      warmSprings.Holes.Add(a);
      warmSprings.Holes.Add(a);

      Courses.Add(warmSprings);
      Courses.Add(quailHollow);
      Courses.Add(indianLakes);

    }
    public void DisplayCourses()
    {
      Console.Clear();
      Console.WriteLine("Boise Golf Guide");
      int count = 1;
      foreach (var course in Courses)
      {
        Console.WriteLine($"{count}. {course.Name}");
        count++;
      }
    }
    public void SelectCourse()
    {
      Console.WriteLine("Where are you playing?");
      switch (Console.ReadLine())
      {
        case "1":
          ActiveCourse = Courses[0];
          break;
        case "2":
          ActiveCourse = Courses[1];
          break;
        case "3":
          ActiveCourse = Courses[2];
          break;
        default:
          Console.WriteLine("Invalid selection.");
          break;
      }
    }
    public void SetPlayers()
    {
      Console.Clear();
      Console.WriteLine("How many players?");
      switch (Console.ReadLine())
      {
        case "1":
          Console.WriteLine("Player name:");
          string playerName = Console.ReadLine();
          Player a = new Player(playerName);
          Players.Add(a);
          break;
        case "2":
          Console.WriteLine("First player's name:");
          string playerNameB = Console.ReadLine();
          Player b = new Player(playerNameB);
          Players.Add(b);
          Console.WriteLine("Second player's name:");
          string playerNameC = Console.ReadLine();
          Player c = new Player(playerNameC);
          Players.Add(c);
          break;
        case "3":
          Console.WriteLine("First player's name:");
          string playerNameD = Console.ReadLine();
          Player d = new Player(playerNameD);
          Players.Add(d);
          Console.WriteLine("Second player's name:");
          string playerNameE = Console.ReadLine();
          Player e = new Player(playerNameE);
          Players.Add(e);
          Console.WriteLine("Third player's name:");
          string playerNameF = Console.ReadLine();
          Player f = new Player(playerNameF);
          Players.Add(f);
          break;
        case "4":
          Console.WriteLine("First player's name:");
          string playerNameG = Console.ReadLine();
          Player g = new Player(playerNameG);
          Players.Add(g);
          Console.WriteLine("Second player's name:");
          string playerNameH = Console.ReadLine();
          Player h = new Player(playerNameH);
          Players.Add(h);
          Console.WriteLine("Third player's name:");
          string playerNameI = Console.ReadLine();
          Player i = new Player(playerNameI);
          Players.Add(i);
          Console.WriteLine("Fourth player's name:");
          string playerNameJ = Console.ReadLine();
          Player j = new Player(playerNameJ);
          Players.Add(j);
          break;
        default:
          Console.WriteLine("Please choose between 1 and 4 players");
          break;
      }
    }
    public void Run()
    {
      foreach (var Hole in ActiveCourse.Holes)
      {
        Console.WriteLine($"Hole {Hole}");
        foreach (var Player in Players)
        {
          Console.WriteLine($"Enter player score:");
          string holeStroke = Console.ReadLine();
          if (Int32.TryParse(holeStroke, out int result))
          {
            Player.Scores.Add(new Score(result, Hole.Number, Hole.Par));
          }
          else
          {
            Console.WriteLine("Invalid entry");
            break;
          }
        }
      }
    }
    public void DisplayPlayerResults()
    {
      foreach (var Player in Players)
      {
        Console.WriteLine($"{Player.Name}'s results:");
        foreach (var Score in Player.Scores)
        {
          Console.WriteLine($"{Score.HoleNumber}: {Score.HoleScore}");
        }
      }
    }
  }
}