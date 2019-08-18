using System.Collections.Generic;
using Golf.Interfaces;

namespace Golf.Models
{
  public class Player : IPlayer
  {
    public string Name { get; set; }
    public List<Score> Scores { get; set; }
    public Player(string name)
    {
      Name = name;
      Scores = new List<Score>();
    }
  }
}