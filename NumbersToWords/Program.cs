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

      // Initialize List of Integers
      // List<double> separatedIntegers = new List<double>();
      // separatedIntegers = numbersToTranslate.NumberSplitter();

      // numbersToTranslate.PartitionedValues = separatedIntegers;

      // Console.WriteLine($"User's Input: {numbersToTranslate.UserInput}");

      // foreach (double item in numbersToTranslate.PartitionedValues)
      // {
      //   Console.WriteLine(item);
      // }




      // Write method:

      // double sum = 0;

      // for (int i = 0; i < userInput.Length; i++) 
      // {
      //   double result = userInputInteger % (Math.Pow(10, i + 1)) - sum;
      //   sum += result;

      //   if (result != 0) 
      //   {
      //     separatedIntegers.Insert(0, result);
      //   }
      // }

      // foreach (int entry in separatedIntegers)
      // {
      //   Console.WriteLine(entry);
      // }

    }
  }
}
