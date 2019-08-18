using System;
using Golf.Interfaces;

namespace Golf.Models
{
  public class Hole : IHole
  {
    public int Par { get; set; }
    public int Distance { get; set; }
    public Hole(int par, int distance)
    {
      Par = par;
      Distance = distance;
    }
  }
}