using System;
using Golf.Interfaces;

namespace Golf.Models
{
  public class Hole : IHole
  {
    public int Par { get; set; }
    public int Number { get; set; }
    public Hole(int par, int number)
    {
      Par = par;
      Number = number;
    }
  }
}