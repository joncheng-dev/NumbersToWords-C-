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
      Console.WriteLine("Welcome to the Numbers To Words app! Enter an integer, and I'll return its numerated form.");
      Console.WriteLine("Enter an integer: ");

      // User Entered String
      string userEnteredString = Console.ReadLine();

      // Constructs an Object -- with User Entered String
      Numbers numbersToTranslate = new Numbers(userEnteredString);

      numbersToTranslate.NumberSplitter();

      Console.WriteLine("Your numerated integer is: \n" + numbersToTranslate.GiveNumeratedUserInput());

      // Console.WriteLine("All elements in list:");
      // foreach(string element in numbersToTranslate.PartitionedValues)
      // {
      //   Console.WriteLine(element);
      // }

    }
  }
}
