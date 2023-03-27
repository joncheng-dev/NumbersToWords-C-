using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class TranslationTests
  {
    // Tests go here
    [TestMethod]
    public void IntToTranslateConstructor_CreatesInstanceOfIntToTranslate_IntToTranslate()
    {
      IntToTranslate newTranslation = new IntToTranslate(2, 1);
      Assert.AreEqual(typeof(IntToTranslate), newTranslation.GetType());
    }

    [TestMethod]
    public void GetOnesDigit_ReturnsOnesDigit_Int()
    {
      int number = 4;
      IntToTranslate newTranslation = new IntToTranslate(number, 2);
      int result = newTranslation.OnesDigit;
      Assert.AreEqual(result, number);
    }

    [TestMethod]
    public void SetOnesDigit_SetsValueOfOnesDigit_Void()
    {
      IntToTranslate newTranslation = new IntToTranslate(3, 9);
      int updatedOnesDigit = 5;
      newTranslation.OnesDigit = updatedOnesDigit;
      Assert.AreEqual(updatedOnesDigit, newTranslation.OnesDigit);
    }

    [TestMethod]
    public void OnesDigitToWords_ReturnsCorrespondingText_String()
    {
      IntToTranslate threeAsNumber = new IntToTranslate(3, 4);
      string returnedText = threeAsNumber.NumberToText();
      Assert.AreEqual("three", returnedText);
    }

    [TestMethod]
    public void FiveNumberToWord_ReturnsTextFive_String()
    {
      IntToTranslate fiveAsNumber = new IntToTranslate(5, 7);
      string returnedText = fiveAsNumber.NumberToText();
      Assert.AreEqual("five", returnedText);
    }

    [TestMethod]
    public void GetTensDigit_ReturnTensDigit_Int()
    {
      int number = 6;
      IntToTranslate newTranslation = new IntToTranslate(4, 6);
      int result = newTranslation.TensDigit;
      Assert.AreEqual(result, number);
    }

    // [TestMethod]
    // public void GetTensDigit_ReturnsTensDigit_Int()
    // {
    //   int number = 
    // }
  }
}