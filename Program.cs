using System;
using Golf.Models;
using Golf.Interfaces;

namespace Golf
{
  class Program
  {
    static void Main(string[] args)
    {
      Boolean active;
      active = true;
      Console.Clear();
      App app = new App();
      while (active)
      {
        app.Setup();
        app.DisplayCourses();
        app.SelectCourse();
        app.SetPlayers();
        app.Run();
        app.DisplayPlayerResults();
        Console.WriteLine("Nice playing! Another round?\n1. Yes\n2. No");
        switch (Console.ReadLine())
        {
          case "1":
            continue;
          case "2":
            active = false;
            break;
          default:
            Console.WriteLine("Invalid entry");
            break;
        }
      }
    }
  }
}
