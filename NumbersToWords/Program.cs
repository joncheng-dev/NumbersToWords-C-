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
      // separatedIntegers.Add(4000);
      // separatedIntegers.Add(300);
      // separatedIntegers.Add(20);
      // separatedIntegers.Add(9);
      // Console.WriteLine("4329 as a list is:\n");

      string userInput = "4329";
      int userInputInteger = int.Parse(userInput);

      int result1 = userInputInteger % 10;
      int result2 = userInputInteger % 100 - result1;
      int result3 = userInputInteger % 1000 - result2 - result1;
      int result4 = userInputInteger % 10000 - result3 - result2 - result1;

      Console.WriteLine(result1);
      Console.WriteLine(result2);
      Console.WriteLine(result3);
      Console.WriteLine(result4);

      // for (int i = 0; i < userInput.Length; i++) 
      // {
      //   separatedIntegers.Add(userInputInteger % (10));
      // }

      // foreach(int number in separatedIntegers)
      // {
      //   Console.WriteLine(number);
      // }


    }
  }
}
