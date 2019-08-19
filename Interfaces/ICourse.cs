using System.Collections.Generic;
using Golf.Models;

namespace Golf.Interfaces
{
  public interface ICourse
  {
    string Name { get; set; }
    List<Hole> Holes { get; set; }
  }
}