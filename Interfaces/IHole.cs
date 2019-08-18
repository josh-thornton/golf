using Golf.Models;

namespace Golf.Interfaces
{
  public interface IHole
  {
    int Par { get; set; }
    int Distance { get; set; }
  }
}