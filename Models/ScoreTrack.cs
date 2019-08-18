namespace Golf.Models
{
  public class Score
  {
    public int HoleScore { get; set; }
    public int HoleNumber { get; set; }
    public int StrokeCount { get; set; }
    public Score(int holescore, int holenumber, int strokecount)
    {
      HoleScore = holescore;
      HoleNumber = holenumber;
      StrokeCount = strokecount;
    }
  }
}