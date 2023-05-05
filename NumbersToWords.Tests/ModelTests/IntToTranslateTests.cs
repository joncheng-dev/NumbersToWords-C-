using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersTests
  {
    // Tests go here
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfNumbers_Numbers()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

    [TestMethod]
    public void GetUserInput_ReturnsUserInput_String()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");

      string text = "24";
      Numbers newNumbers = new Numbers(text, newPartition, "twenty four");
      string returnedText = newNumbers.UserInput;
      Assert.AreEqual(text, returnedText);
    }

    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");  

      Numbers newNumbers = new Numbers("789", newPartition, "twenty four");
      string newUserInput = "24";
      newNumbers.UserInput = newUserInput;
      Assert.AreEqual(newUserInput, newNumbers.UserInput);
    }

    [TestMethod]
    public void GetPartitionedValues_ReturnsPartitionedValues_List()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      List<string> result = newNumbers.PartitionedValues;

      Assert.AreEqual(newPartition, result);
    }

    [TestMethod]
    public void SetPartitionedValues_SetsValuesOfPartitionedValues_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      List<string> newList = new List<string>()
      {
        "700",
        "080",
        "009",
      };

      newNumbers.PartitionedValues = newList;

      Assert.AreEqual(newList, newNumbers.PartitionedValues);
    }

    [TestMethod]
    public void GetNumerated_GetsValueOfNumerated_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      string result = newNumbers.Numerated;

      Assert.AreEqual(result, "twenty four");
    }

    [TestMethod]
    public void SetNumerated_SetsValueOfNumerated_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      string newNumerated = "three hundred";
      newNumbers.Numerated = newNumerated;

      Assert.AreEqual(newNumerated, newNumbers.Numerated);
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList009_Void()
    {
      string userInput = "9";
      List<string> newPartition = new List<string>();
      newPartition.Add("009"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList011_Void()
    {
      string userInput = "11";
      List<string> newPartition = new List<string>();
      newPartition.Add("011"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList200_Void()
    {
      string userInput = "200";
      List<string> newPartition = new List<string>();
      newPartition.Add("200"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void TripletIntoPlaceValues_ReturnsATripletIntoACharacterList_Void()
    {
      string userInput = "1";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "001"
      newNumbers.TripletIntoPlaceValues("001");
    }

    // [TestMethod]
    // public void GiveNumeratedTriplet_PlacesDigitsInAListThenUsesLocationInListWithDictionaryToTranslateToWords1_Void()
    // {
    //   string userInput = "1";

    //   Numbers newNumbers = new Numbers(userInput);
    //   newNumbers.NumberSplitter();
    //   // PartitionedValues is now "001"
    //   newNumbers.GiveNumeratedTriplet()
    // }

    // [TestMethod]
    // public void GiveNumeratedTriplet_UsesDictionaryToNumerateATriplet100_String()
    // {
    //   string userInput = "100";
    //   List<string> newPartition = new List<string>();
    //   newPartition.Add("100");       

    //   Numbers newNumbers = new Numbers(userInput);
    //   newNumbers.NumberSplitter();

    //   for (int i = 0; i < newPartition.Count; i++)
    //   {
    //     newNumbers.GiveNumeratedTriplet(newPartition[i]);
    //   }

    //   string expectedResult = "one hundred";

    //   Assert.AreEqual(expectedResult, newNumbers.Numerated);
    // }

    // [TestMethod]
    // public void GiveNumeratedForm_UsesDictionaryToTranslateNumber1700012ToText_String()
    // {
    //   string userInput = "1700012";
    //   List<double> newPartition = new List<double>();
    //   newPartition.Add(1000000);
    //   newPartition.Add(700000);
    //   newPartition.Add(10);
    //   newPartition.Add(2);      

    //   Numbers newNumbers = new Numbers(userInput, newPartition);

    //   string expectedResult = "one million seven hundred thousand twelve";
    //   newNumbers.GiveNumeratedForm();

    //   Assert.AreEqual(expectedResult, newNumbers.Numerated);
    // }    
  }
}