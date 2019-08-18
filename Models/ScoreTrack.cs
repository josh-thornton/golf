using System.Collections.Generic;

namespace Golf.Models
{
  public class Score
  {
    public int HoleScore { get; set; }
    public int HoleNumber { get; set; }
    public int HolePar { get; set; }
    public Score(int holescore, int holenumber, int holepar)
    {
      HoleScore = holescore;
      HoleNumber = holenumber;
      HolePar = holepar;
    }
  }
}