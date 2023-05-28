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

      Numbers newNumbers = new Numbers("24", newPartition);
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

    [TestMethod]
    public void GetUserInput_ReturnsUserInput_String()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");

      string text = "24";
      Numbers newNumbers = new Numbers(text, newPartition);
      string returnedText = newNumbers.UserInput;
      Assert.AreEqual(text, returnedText);
    }

    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");  

      Numbers newNumbers = new Numbers("789", newPartition);
      string newUserInput = "24";
      newNumbers.UserInput = newUserInput;
      Assert.AreEqual(newUserInput, newNumbers.UserInput);
    }

    [TestMethod]
    public void GetPartitionedValues_ReturnsPartitionedValues_List()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition);

      List<string> result = newNumbers.PartitionedValues;

      Assert.AreEqual(newPartition, result);
    }

    [TestMethod]
    public void SetPartitionedValues_SetsValuesOfPartitionedValues_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      Numbers newNumbers = new Numbers("24", newPartition);

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
    public void GetNumeratedTriplets_GetsValueOfNumerated_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024");

      List<string> aListOfStrings = new List<string>();
      aListOfStrings.Add("012");
      aListOfStrings.Add("036");

      Numbers newNumbers = new Numbers("24", newPartition, aListOfStrings);

      List<string> result = newNumbers.NumeratedTriplets;

      Assert.AreEqual(result, aListOfStrings);
    }

    [TestMethod]
    public void SetNumerated_SetsValueOfNumerated_Void()
    {
      List<string> newPartition = new List<string>();
      newPartition.Add("024"); 

      List<string> aListOfStrings = new List<string>();
      aListOfStrings.Add("012");
      aListOfStrings.Add("036");

      Numbers newNumbers = new Numbers("24", newPartition, aListOfStrings);

      List<string> newListOfStrings = new List<string>()
      {
        "345",
        "678",
        "901",
      };
      
      newNumbers.NumeratedTriplets = newListOfStrings;
      Assert.AreEqual(newListOfStrings, newNumbers.NumeratedTriplets);
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
    public void TripletIntoPlaceValues_ReturnsATriplet001IntoACharacterList_Void()
    {
      string userInput = "1";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "001"
      // result should be a list of 0, 0, 1
      List<char> result = Numbers.TripletIntoPlaceValues("001");
      // List to compare results to -- 
      List<char> testList = new List<char>();
      testList.Add('0');
      testList.Add('0');
      testList.Add('1');
      // Check if both lists match in composition.            
      Assert.AreEqual(result.Count, testList.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], testList[i]);
      }
    }

    [TestMethod]
    public void TripletIntoPlaceValues_ReturnsATriplet302IntoACharacterList_Void()
    {
      string userInput = "302";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "302"
      // result should be a list of 3, 0, 2
      List<char> result = Numbers.TripletIntoPlaceValues("302");
      // List to compare results to -- 
      List<char> testList = new List<char>();
      testList.Add('3');
      testList.Add('0');
      testList.Add('2');
      // Check if both lists match in composition.            
      Assert.AreEqual(result.Count, testList.Count);
      for (int i = 0; i < result.Count; i++)
      {
        Assert.AreEqual(result[i], testList[i]);
      }
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary1_Void()
    {
      string userInput = "1";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "001"
      // Separate into digits of place value.
      // index 0 --> hundreds
      // index 1 --> tens
      // index 2 --> ones
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("001");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "one";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(numeratedTriplet, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList254_Void()
    {
      string userInput = "254";
      List<string> newPartition = new List<string>();
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList1254_Void()
    {
      // string userInput = "4200";
      string userInput = "1254";
      List<string> newPartition = new List<string>();
      newPartition.Add("001");
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList71254_Void()
    {
      string userInput = "71254";
      List<string> newPartition = new List<string>();
      newPartition.Add("071");
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList671254_Void()
    {
      string userInput = "671254";
      List<string> newPartition = new List<string>();
      newPartition.Add("671");
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList9671254_Void()
    {
      string userInput = "9671254";
      List<string> newPartition = new List<string>();
      newPartition.Add("009");
      newPartition.Add("671");
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList90671254_Void()
    {
      string userInput = "90671254";
      List<string> newPartition = new List<string>();
      newPartition.Add("090");
      newPartition.Add("671");
      newPartition.Add("254"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList890671452_Void()
    {
      string userInput = "890671452";
      List<string> newPartition = new List<string>();
      newPartition.Add("890");
      newPartition.Add("671");
      newPartition.Add("452"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_UserInputIntoTripletsInList3890671452_Void()
    {
      string userInput = "3890671452";
      List<string> newPartition = new List<string>();
      newPartition.Add("003");
      newPartition.Add("890");
      newPartition.Add("671");
      newPartition.Add("452"); 

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary100_Void()
    {
      string userInput = "100";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "100"
      // Separate into digits of place value.
      // index 0 --> hundreds
      // index 1 --> tens
      // index 2 --> ones
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("100");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "one hundred";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(result, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary70_Void()
    {
      string userInput = "70";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "070"
      // Separate into digits of place value.
      // index 0 --> hundreds
      // index 1 --> tens
      // index 2 --> ones
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("070");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "seventy";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(numeratedTriplet, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary13_Void()
    {
      string userInput = "13";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "013"
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("013");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "thirteen";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(numeratedTriplet, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary23_Void()
    {
      string userInput = "23";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "023"
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("023");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "twenty three";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(numeratedTriplet, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary519_Void()
    {
      string userInput = "519";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "519"
      List<char> tripletIntoChars = Numbers.TripletIntoPlaceValues("519");
      string result = Numbers.GiveNumeratedTriplet(tripletIntoChars);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "five hundred nineteen";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(numeratedTriplet, newNumbers.NumeratedTriplets[0]);
    }

    [TestMethod]
    public void GiveNumeratedTriplet_TakesListOfDigitsInPlaceValuesAndTranslatesToWordsUsingDictionary888_Void()
    {
      string userInput = "888";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues is now "888"
      List<char> inputTriplet = Numbers.TripletIntoPlaceValues("888");
      string result = Numbers.GiveNumeratedTriplet(inputTriplet);

      List<string> tempList = new List<string>();
      tempList.Add(result);

      List<string> testing = new List<string>();
      string numeratedTriplet = "eight hundred eighty eight";
      testing.Add(numeratedTriplet);

      newNumbers.NumeratedTriplets = tempList;

      Assert.AreEqual(testing[0], newNumbers.NumeratedTriplets[0]);

      // Assert.AreEqual(testing.Count, newNumbers.NumeratedTriplets.Count);
      // for (int i = 0; i < testing.Count; i++)
      // {
      //   Assert.AreEqual(testing[i], newNumbers.NumeratedTriplets[i]);
      // }      
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult1001_Void()
    {
      string userInput = "1001";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();
      // PartitionedValues should be..
      // PartitionedValues[0] = "001";
      // PartitionedValues[1] = "001";
      
      // PartitionedValues[0] gets sent to TripletIntoPlaceValues
      // returned List: 0, 0, 1 

      string concatenatedTest = "one thousand one";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult1888_Void()
    {
      string userInput = "1888";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "one thousand eight hundred eighty eight";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult12345_Void()
    {
      string userInput = "12345";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "twelve thousand three hundred forty five";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult123456_Void()
    {
      string userInput = "123456";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "one hundred twenty three thousand four hundred fifty six";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult1234567_Void()
    {
      string userInput = "1234567";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "one million two hundred thirty four thousand five hundred sixty seven";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult12345678_Void()
    {
      string userInput = "12345678";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "twelve million three hundred forty five thousand six hundred seventy eight";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    [TestMethod]
    public void TranslateUserInput_TakesUserInputCallsOtherMethodsReturnsNumeratedResult123456789_Void()
    {
      string userInput = "123456789";

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      string concatenatedTest = "one hundred twenty three million four hundred fifty six thousand seven hundred eighty nine";
      string concatenatedUserInput = newNumbers.GiveNumeratedUserInput();

      Assert.AreEqual(concatenatedTest, concatenatedUserInput);          
    }

    // [TestMethod]
    // public void GiveNumeratedTotalNumber_CountsElementsOfPartitionedValuesAndCorrectlyConcatenatesTotalString1_Void()
    // {
    //   string userInput = "1";
    //   Numbers newNumbers = new Numbers(userInput);
    //   newNumbers.NumberSplitter();
    //   // PartitionedValues is now "001";
    //   newNumbers.GiveNumeratedTriplet(Numbers.TripletIntoPlaceValues(newNumbers.PartitionedValues[0]));
    //   // Call some method or function which combines total numeration
    //   // based on numbers of elements in PartitionedValues list;

    //   // Use in method or function -- newNumbers.PartitionedValues.Count

    //   string finalNumeratedNumber = "one";
    //   Assert.AreEqual(newNumbers.Numerated, finalNumeratedNumber);

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