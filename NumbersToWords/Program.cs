using System; 
using NumberToWords.Models;

// Contains User Interface logic 
namespace NumberToWords
{
  class Program 
  {
    static void Main()
    {
      Translation testTranslation = new Translation();
      Console.WriteLine(testTranslation.GetType());
    }
  }
}
