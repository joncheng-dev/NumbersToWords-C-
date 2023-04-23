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

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber15ToText_String()
    {
      string userInput = "15";
      List<double> newPartition = new List<double>();
      newPartition.Add(10);
      newPartition.Add(5);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "fifteen";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber315ToText_String()
    {
      string userInput = "315";
      List<double> newPartition = new List<double>();
      newPartition.Add(300);
      newPartition.Add(10);
      newPartition.Add(5);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "three hundred fifteen";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }    

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber959ToText_String()
    {
      string userInput = "959";
      List<double> newPartition = new List<double>();
      newPartition.Add(900);
      newPartition.Add(50);
      newPartition.Add(9);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "nine hundred fifty nine";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber731ToText_String()
    {
      string userInput = "731";
      List<double> newPartition = new List<double>();
      newPartition.Add(700);
      newPartition.Add(30);
      newPartition.Add(1);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "seven hundred thirty one";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber1000ToText_String()
    {
      string userInput = "1000";
      List<double> newPartition = new List<double>();
      newPartition.Add(1000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "one thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    } 

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber1216ToText_String()
    {
      string userInput = "1216";
      List<double> newPartition = new List<double>();
      newPartition.Add(1000);
      newPartition.Add(200);
      newPartition.Add(10);
      newPartition.Add(6);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "one thousand two hundred sixteen";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }        

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber10216ToText_String()
    {
      string userInput = "13216";
      List<double> newPartition = new List<double>();
      newPartition.Add(10000);
      newPartition.Add(3000);
      newPartition.Add(200);
      newPartition.Add(10);
      newPartition.Add(6);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "thirteen thousand two hundred sixteen";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber99999ToText_String()
    {
      string userInput = "99999";
      List<double> newPartition = new List<double>();
      newPartition.Add(90000);
      newPartition.Add(9000);
      newPartition.Add(900);
      newPartition.Add(90);
      newPartition.Add(9);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "ninety nine thousand nine hundred ninety nine";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }                  

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber90000ToText_String()
    {
      string userInput = "90000";
      List<double> newPartition = new List<double>();
      newPartition.Add(90000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "ninety thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber10000ToText_String()
    {
      string userInput = "10000";
      List<double> newPartition = new List<double>();
      newPartition.Add(10000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "ten thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber200000ToText_String()
    {
      string userInput = "200000";
      List<double> newPartition = new List<double>();
      newPartition.Add(200000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "two hundred thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }   

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber430000ToText_String()
    {
      string userInput = "430000";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber435000ToText_String()
    {
      string userInput = "439000";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);
      newPartition.Add(9000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty nine thousand";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber435700ToText_String()
    {
      string userInput = "439700";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);
      newPartition.Add(9000);
      newPartition.Add(700);
          
      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty nine thousand seven hundred";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber435760ToText_String()
    {
      string userInput = "439760";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);
      newPartition.Add(9000);
      newPartition.Add(700);
      newPartition.Add(60);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty nine thousand seven hundred sixty";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber439715ToText_String()
    {
      string userInput = "439715";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);
      newPartition.Add(9000);
      newPartition.Add(700);  
      newPartition.Add(10);
      newPartition.Add(5);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty nine thousand seven hundred fifteen";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    } 

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber439710ToText_String()
    {
      string userInput = "439710";
      List<double> newPartition = new List<double>();
      newPartition.Add(400000);
      newPartition.Add(30000);
      newPartition.Add(9000);
      newPartition.Add(700);  
      newPartition.Add(10);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "four hundred thirty nine thousand seven hundred ten";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }   

    [TestMethod]
    public void GiveNumeratedForm_UsesDictionaryToTranslateNumber1000000ToText_String()
    {
      string userInput = "1000000";
      List<double> newPartition = new List<double>();
      newPartition.Add(1000000);

      Numbers newNumbers = new Numbers(userInput, newPartition);

      string expectedResult = "one million";
      newNumbers.GiveNumeratedForm();

      Assert.AreEqual(expectedResult, newNumbers.Numerated);
    }             
  }
}