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
      // Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      // Console.WriteLine("Enter a number, and it will be translated to words.");
      // Console.WriteLine("Enter any integer:\n");
      // string userEnteredString = Console.ReadLine();

      // int enteredInteger = int.Parse(userEnteredString);

      // IntToTranslate toTranslate = new IntToTranslate(enteredInteger, 8);
      // string translated = toTranslate.NumberToText();

      // Console.WriteLine("                             \n");

      // Console.WriteLine($"You entered: {userEnteredString}.");

      // Console.WriteLine($"Translated: {translated}.");

      // Initialize List of Integers
      List<double> separatedIntegers = new List<double>();

      string userInput = "1921238";
      int userInputInteger = int.Parse(userInput);



      double sum = 0;

      for (int i = 0; i < userInput.Length; i++) 
      {
        double result = userInputInteger % (Math.Pow(10, i + 1)) - sum;
        sum += result;
        separatedIntegers.Add(result);
      }

      foreach (int entry in separatedIntegers)
      {
        Console.WriteLine(entry);
      }

    }
  }
}
