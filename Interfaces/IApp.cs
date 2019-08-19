using System.Collections.Generic;
using Golf.Models;

namespace Golf.Interfaces
{
  public interface IApp
  {
    Course ActiveCourse { get; set; }
    List<Player> Players { get; set; }
    List<Course> Courses { get; set; }

    void Setup();
    void DisplayCourses();
    void SelectCourse();
    void DisplayPlayerResults();
  }
}