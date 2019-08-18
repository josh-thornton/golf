using System;
using System.Collections.Generic;
using Golf.Interfaces;
using Golf.Models;

namespace Golf
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      App app = new App();
      {
        app.Setup();
        app.DisplayCourses();
        app.SelectCourse();
        app.SetPlayers();

      }
    }
  }
}
