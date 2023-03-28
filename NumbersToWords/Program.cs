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
      List<int> separatedIntegers = new List<int>();
      separatedIntegers.Add(4000);
      separatedIntegers.Add(300);
      separatedIntegers.Add(20);
      separatedIntegers.Add(9);
      Console.WriteLine("4329 as a list is:\n");

      foreach(int number in separatedIntegers)
      {
        Console.WriteLine(number);
      }

    }
  }
}
