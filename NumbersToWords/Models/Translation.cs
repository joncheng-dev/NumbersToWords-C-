// Business logic
namespace NumbersToWords.Models
{
  public class Translation
  {
    private int _onesDigit;

    public int OnesDigit
    {
      get { return _onesDigit; }
      set { _onesDigit = value; }
    }

    public Translation(int num)
    {
      _onesDigit = num;
    }
  }
}
