using System.Collections.Generic;

// Business logic
namespace NumbersToWords.Models
{
  public class IntToTranslate
  {
    // Ones digit placeholder
    private int _onesDigit;

    // Ones digit Get & Set
    public int OnesDigit
    {
      get { return _onesDigit; }
      set { _onesDigit = value; }
    }

    // Constructor 
    public IntToTranslate(int onesPlace)
    {
      _onesDigit = onesPlace;
    }

    public string NumberToText()
    {
      int index = _onesDigit;
      return onesTranslation[index];
    }

    // Translator for Ones Digit
    Dictionary<int, string> onesTranslation = new Dictionary<int, string>()
    {
      { 1, "one" },
      { 2, "two" },
      { 3, "three" },
      { 4, "four" },
      { 5, "five" },
      { 6, "six" },
      { 7, "seven" },
      { 8, "eight" },
      { 9, "nine" },
    };



  }
}
