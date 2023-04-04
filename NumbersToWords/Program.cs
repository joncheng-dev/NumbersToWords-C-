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
      int enteredInteger = int.Parse(userEnteredString);

      // Constructs an Object -- with User Entered String
      Numbers numbersToTranslate = new Numbers(userEnteredString);

      // Initialize List of Integers
      List<double> separatedIntegers = new List<double>();
      separatedIntegers.Add(10);
      separatedIntegers.Add(2);

      numbersToTranslate.PartitionedValues = separatedIntegers;

      Console.WriteLine($"User's Input: {numbersToTranslate.UserInput}");

      foreach (double item in numbersToTranslate.PartitionedValues)
      {
        Console.WriteLine(item);
      }

      // string userInput = "1219";
      // int userInputInteger = int.Parse(userInput);



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
