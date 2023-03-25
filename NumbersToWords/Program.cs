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

      Translation tran = new Translation(enteredInteger);

      Console.WriteLine($"Your entered integer is: {userEnteredString}.");      
      Console.WriteLine($"Translation is currently: {tran}");

    }
  }
}
