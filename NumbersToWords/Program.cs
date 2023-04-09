using System; 
using NumbersToWords.Models;
using System.Collections.Generic;

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
      Console.WriteLine("Enter any integer:");

      // User Entered String
      string userEnteredString = Console.ReadLine();

      // Constructs an Object -- with User Entered String
      Numbers numbersToTranslate = new Numbers(userEnteredString);

      numbersToTranslate.NumberSplitter();

      Console.WriteLine("All elements in list:");
      foreach(double element in numbersToTranslate.PartitionedValues)
      {
        Console.WriteLine(element);
      }

    }
  }
}
