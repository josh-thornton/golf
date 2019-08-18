using System;
using System.Collections.Generic;
using System.Linq;
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

      Hole w1 = new Hole(4, 1);
      Hole w2 = new Hole(4, 2);
      Hole w3 = new Hole(4, 3);
      Hole w4 = new Hole(3, 4);
      Hole w5 = new Hole(4, 5);
      Hole w6 = new Hole(5, 6);
      Hole w7 = new Hole(4, 7);
      Hole w8 = new Hole(3, 8);
      Hole w9 = new Hole(5, 9);
      Hole w10 = new Hole(4, 10);
      Hole w11 = new Hole(4, 11);
      Hole w12 = new Hole(5, 12);
      Hole w13 = new Hole(3, 13);
      Hole w14 = new Hole(4, 14);
      Hole w15 = new Hole(5, 15);
      Hole w16 = new Hole(4, 16);
      Hole w17 = new Hole(4, 17);
      Hole w18 = new Hole(3, 18);

      Hole q1 = new Hole(4, 1);
      Hole q2 = new Hole(3, 2);
      Hole q3 = new Hole(4, 3);
      Hole q4 = new Hole(3, 4);
      Hole q5 = new Hole(4, 5);
      Hole q6 = new Hole(4, 6);
      Hole q7 = new Hole(5, 7);
      Hole q8 = new Hole(4, 8);
      Hole q9 = new Hole(4, 9);
      Hole q10 = new Hole(4, 10);
      Hole q11 = new Hole(4, 11);
      Hole q12 = new Hole(4, 12);
      Hole q13 = new Hole(4, 13);
      Hole q14 = new Hole(4, 14);
      Hole q15 = new Hole(3, 15);
      Hole q16 = new Hole(5, 16);
      Hole q17 = new Hole(3, 17);
      Hole q18 = new Hole(4, 18);

      Hole l1 = new Hole(4, 1);
      Hole l2 = new Hole(4, 2);
      Hole l3 = new Hole(3, 3);
      Hole l4 = new Hole(4, 4);
      Hole l5 = new Hole(4, 5);
      Hole l6 = new Hole(5, 6);
      Hole l7 = new Hole(3, 7);
      Hole l8 = new Hole(4, 8);
      Hole l9 = new Hole(4, 9);
      Hole l10 = new Hole(4, 10);
      Hole l11 = new Hole(4, 11);
      Hole l12 = new Hole(3, 12);
      Hole l13 = new Hole(4, 13);
      Hole l14 = new Hole(4, 14);
      Hole l15 = new Hole(5, 15);
      Hole l16 = new Hole(3, 16);
      Hole l17 = new Hole(4, 17);
      Hole l18 = new Hole(4, 18);

      warmSprings.Holes.Add(w1);
      warmSprings.Holes.Add(w2);
      warmSprings.Holes.Add(w3);
      warmSprings.Holes.Add(w4);
      warmSprings.Holes.Add(w5);
      warmSprings.Holes.Add(w6);
      warmSprings.Holes.Add(w7);
      warmSprings.Holes.Add(w8);
      warmSprings.Holes.Add(w9);
      warmSprings.Holes.Add(w10);
      warmSprings.Holes.Add(w11);
      warmSprings.Holes.Add(w12);
      warmSprings.Holes.Add(w13);
      warmSprings.Holes.Add(w14);
      warmSprings.Holes.Add(w15);
      warmSprings.Holes.Add(w16);
      warmSprings.Holes.Add(w17);
      warmSprings.Holes.Add(w18);

      quailHollow.Holes.Add(q1);
      quailHollow.Holes.Add(q2);
      quailHollow.Holes.Add(q3);
      quailHollow.Holes.Add(q4);
      quailHollow.Holes.Add(q5);
      quailHollow.Holes.Add(q6);
      quailHollow.Holes.Add(q7);
      quailHollow.Holes.Add(q8);
      quailHollow.Holes.Add(q9);
      quailHollow.Holes.Add(q10);
      quailHollow.Holes.Add(q11);
      quailHollow.Holes.Add(q12);
      quailHollow.Holes.Add(q13);
      quailHollow.Holes.Add(q14);
      quailHollow.Holes.Add(q15);
      quailHollow.Holes.Add(q16);
      quailHollow.Holes.Add(q17);
      quailHollow.Holes.Add(q18);

      indianLakes.Holes.Add(l1);
      indianLakes.Holes.Add(l2);
      indianLakes.Holes.Add(l3);
      indianLakes.Holes.Add(l4);
      indianLakes.Holes.Add(l5);
      indianLakes.Holes.Add(l6);
      indianLakes.Holes.Add(l7);
      indianLakes.Holes.Add(l8);
      indianLakes.Holes.Add(l9);
      indianLakes.Holes.Add(l10);
      indianLakes.Holes.Add(l11);
      indianLakes.Holes.Add(l12);
      indianLakes.Holes.Add(l13);
      indianLakes.Holes.Add(l14);
      indianLakes.Holes.Add(l15);
      indianLakes.Holes.Add(l16);
      indianLakes.Holes.Add(l17);
      indianLakes.Holes.Add(l18);

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
          SelectCourse();
          break;
      }
    }
    public void SetPlayers()
    {
      Console.Clear();
      Console.WriteLine($"You have selected {ActiveCourse.Name}.");
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
          SetPlayers();
          break;
      }
    }
    public void Run()
    {
      foreach (var Hole in ActiveCourse.Holes)
      {
        Console.Clear();
        Console.WriteLine($"Hole: {Hole.Number}\nPar: {Hole.Par}");
        foreach (var Player in Players)
        {
          Console.WriteLine($"Enter {Player.Name}'s score:");
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
      Console.Clear();
      foreach (var Player in Players)
      {
        Console.WriteLine($"{Player.Name}'s results:");
        foreach (var Score in Player.Scores)
        {
          Console.WriteLine($"Hole: {Score.HoleNumber} Strokes: {Score.HoleScore} Par: {Score.HolePar}");
        }
      }
    }
  }
}