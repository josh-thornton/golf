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
      app.Setup();
      app.DisplayCourses();
      app.SelectCourse();
      app.SetPlayers();
      while (active)
      {
        app.DisplayPlayerResults();
      }


    }
  }
}
