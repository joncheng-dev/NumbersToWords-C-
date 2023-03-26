using System; 
using NumbersToWords.Models;

// Contains User Interface logic 
namespace NumbersToWords
{
  class Program 
  {
    static void Main()
    {
      // UI goes here.
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Enter a number, and it will be translated to words.");
      Console.WriteLine("Enter any integer:\n");
      string userEnteredString = Console.ReadLine();

      int enteredInteger = int.Parse(userEnteredString);

      IntToTranslate toTranslate = new IntToTranslate(enteredInteger);
      string translated = toTranslate.NumberToText();

      Console.WriteLine("                             \n");

      Console.WriteLine($"You entered: {userEnteredString}.");

      Console.WriteLine($"Translated: {translated}.");

    }
  }
}
