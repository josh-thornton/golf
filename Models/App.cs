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
    public void Setup()
    {
      Course warmSprings = new Course("Warm Springs");
      Course quailHollow = new Course("Quail Hollow");
      Course indianLakes = new Course("Indian Lakes");

      Courses.Add(warmSprings);
      Courses.Add(quailHollow);
      Courses.Add(indianLakes);

      Hole w1 = new Hole(4, 397);
      Hole w2 = new Hole(4, 357);
      Hole w3 = new Hole(4, 370);
      Hole w4 = new Hole(3, 138);
      Hole w5 = new Hole(4, 367);
      Hole w6 = new Hole(5, 542);
      Hole w7 = new Hole(4, 409);
      Hole w8 = new Hole(3, 176);
      Hole w9 = new Hole(5, 440);
      Hole w10 = new Hole(4, 334);
      Hole w11 = new Hole(4, 400);
      Hole w12 = new Hole(5, 497);
      Hole w13 = new Hole(3, 141);
      Hole w14 = new Hole(4, 373);
      Hole w15 = new Hole(5, 503);
      Hole w16 = new Hole(4, 387);
      Hole w17 = new Hole(4, 381);
      Hole w18 = new Hole(3, 173);

      Hole q1 = new Hole(4, 227);
      Hole q2 = new Hole(3, 179);
      Hole q3 = new Hole(4, 339);
      Hole q4 = new Hole(3, 149);
      Hole q5 = new Hole(4, 333);
      Hole q6 = new Hole(4, 375);
      Hole q7 = new Hole(5, 469);
      Hole q8 = new Hole(4, 379);
      Hole q9 = new Hole(4, 370);
      Hole q10 = new Hole(4, 383);
      Hole q11 = new Hole(4, 294);
      Hole q12 = new Hole(4, 344);
      Hole q13 = new Hole(4, 356);
      Hole q14 = new Hole(4, 293);
      Hole q15 = new Hole(3, 170);
      Hole q16 = new Hole(5, 477);
      Hole q17 = new Hole(3, 138);
      Hole q18 = new Hole(4, 402);

      Hole l1 = new Hole(4, 325);
      Hole l2 = new Hole(4, 375);
      Hole l3 = new Hole(3, 220);
      Hole l4 = new Hole(4, 386);
      Hole l5 = new Hole(4, 400);
      Hole l6 = new Hole(5, 523);
      Hole l7 = new Hole(3, 170);
      Hole l8 = new Hole(4, 300);
      Hole l9 = new Hole(4, 320);
      Hole l10 = new Hole(4, 340);
      Hole l11 = new Hole(4, 360);
      Hole l12 = new Hole(3, 170);
      Hole l13 = new Hole(4, 366);
      Hole l14 = new Hole(4, 435);
      Hole l15 = new Hole(5, 530);
      Hole l16 = new Hole(3, 208);
      Hole l17 = new Hole(4, 288);
      Hole l18 = new Hole(4, 330);

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
      Console.WriteLine($"You have selected {ActiveCourse}.");
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

    }


  }
}