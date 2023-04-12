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
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("456", newPartition, "twenty four");
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

    [TestMethod]
    public void GetUserInput_ReturnsUserInput_String()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      string text = "123";
      Numbers newNumbers = new Numbers(text, newPartition, "twenty four");
      string returnedText = newNumbers.UserInput;
      Assert.AreEqual(text, returnedText);
    }

    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);    

      Numbers newNumbers = new Numbers("789", newPartition, "twenty four");
      string newUserInput = "123";
      newNumbers.UserInput = newUserInput;
      Assert.AreEqual(newUserInput, newNumbers.UserInput);
    }

    [TestMethod]
    public void GetPartitionedValues_ReturnsPartitionedValues_List()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("789", newPartition, "twenty four");

      List<double> result = newNumbers.PartitionedValues;

      Assert.AreEqual(newPartition, result);
    }

    [TestMethod]
    public void SetPartitionedValues_SetsValuesOfPartitionedValues_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("789", newPartition, "twenty four");

      List<double> newList = new List<double>()
      {
        700,
        80,
        9,
      };

      newNumbers.PartitionedValues = newList;

      Assert.AreEqual(newList, newNumbers.PartitionedValues);
    }

    [TestMethod]
    public void GetNumerated_GetsValueOfNumerated_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      string result = newNumbers.Numerated;

      Assert.AreEqual(result, "twenty four");
    }

    [TestMethod]
    public void SetNumerated_SetsValueOfNumerated_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("24", newPartition, "twenty four");

      string newNumerated = "three hundred";
      newNumbers.Numerated = newNumerated;

      Assert.AreEqual(newNumerated, newNumbers.Numerated);
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber9IntoPartitions_Void()
    {
      string userInput = "9";
      List<double> newPartition = new List<double>();
      newPartition.Add(9);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber10IntoPartitions_Void()
    {
      string userInput = "10";
      List<double> newPartition = new List<double>();
      newPartition.Add(10);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber12IntoPartitions_Void()
    {
      string userInput = "12";
      List<double> newPartition = new List<double>();
      newPartition.Add(10);
      newPartition.Add(2);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber100IntoPartitions_Void()
    {
      string userInput = "100";
      List<double> newPartition = new List<double>();
      newPartition.Add(100);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber384IntoPartitions_Void()
    {
      string userInput = "384";
      List<double> newPartition = new List<double>();
      newPartition.Add(300);
      newPartition.Add(80);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void NumberSplitter_SplitsNumber4286IntoPartitions_Void()
    {
      string userInput = "4286";
      List<double> newPartition = new List<double>();
      newPartition.Add(4000);
      newPartition.Add(200);
      newPartition.Add(80);
      newPartition.Add(6);

      Numbers newNumbers = new Numbers(userInput);
      newNumbers.NumberSplitter();

      Assert.AreEqual(newPartition.Count, newNumbers.PartitionedValues.Count);
      for (int i = 0; i < newPartition.Count; i++)
      {
        Assert.AreEqual(newPartition[i], newNumbers.PartitionedValues[i]);
      }
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber5ToText_String()
    {
      string userInput = "5";
      List<double> newPartition = new List<double>();
      newPartition.Add(5);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "five";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber20ToText_String()
    {
      string userInput = "20";
      List<double> newPartition = new List<double>();
      newPartition.Add(20);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "twenty";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber25ToText_String()
    {
      string userInput = "25";
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(5);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "twenty five";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

  }
}