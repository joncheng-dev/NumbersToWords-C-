using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;
using System.Collections.Generic;


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

      Numbers newNumbers = new Numbers("456", newPartition);
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

    [TestMethod]
    public void GetUserInput_ReturnsUserInput_String()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      string text = "123";
      Numbers newNumbers = new Numbers(text, newPartition);
      string returnedText = newNumbers.UserInput;
      Assert.AreEqual(text, returnedText);
    }

    [TestMethod]
    public void SetUserInput_SetsValueOfUserInput_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);    

      Numbers newNumbers = new Numbers("789", newPartition);
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

      Numbers newNumbers = new Numbers("789", newPartition);

      List<double> result = newNumbers.PartitionedValues;

      Assert.AreEqual(newPartition, result);
    }

    [TestMethod]
    public void SetPartitionedValues_SetsValuesOfPartitionedValues_Void()
    {
      List<double> newPartition = new List<double>();
      newPartition.Add(20);
      newPartition.Add(4);

      Numbers newNumbers = new Numbers("789", newPartition);

      List<double> newList = new List<double>()
      {
        700,
        80,
        9,
      };

      newNumbers.PartitionedValues = newList;

      Assert.AreEqual(newList, newNumbers.PartitionedValues);

    }
  }
}