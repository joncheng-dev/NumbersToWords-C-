using System.Collections.Generic;

// Business logic
namespace NumbersToWords.Models
{
  public class IntToTranslate
  {
    // Place-Value Integers
    private int _onesDigit;
    private int _tensDigit;

    // Digit Get & Set
    public int OnesDigit
    {
      get { return _onesDigit; }
      set { _onesDigit = value; }
    }

    public int TensDigit
    {
      get { return _tensDigit; }
    }

    // Constructor (with overloaded Constructors)
    public IntToTranslate(int onesPlace, int tensPlace)
    {
      _onesDigit = onesPlace;
      _tensDigit = tensPlace;
    }

    public string NumberToText()
    {
      int index = _onesDigit;
      return onesTranslation[index];
    }

    // Translators
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

    Dictionary<int, string> tensTranslation = new Dictionary<int, string>()
    {
      { 10, "ten" },
      { 11, "eleven" },
      { 12, "twelve" },
      { 13, "thirteen" },
      { 14, "fourteen" },
      { 15, "fifteen" },
      { 16, "sixteen" },
      { 17, "seventeen" },
      { 18, "eighteen" },
      { 19, "nineteen" },
    };

  }
}
