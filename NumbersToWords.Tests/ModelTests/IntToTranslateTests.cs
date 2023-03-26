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
      IntToTranslate newTranslation = new IntToTranslate(2);
      Assert.AreEqual(typeof(IntToTranslate), newTranslation.GetType());
    }

    [TestMethod]
    public void GetOnesDigit_ReturnsOnesDigit_Int()
    {
      int number = 4;
      IntToTranslate newTranslation = new IntToTranslate(number);
      int result = newTranslation.OnesDigit;
      Assert.AreEqual(result, number);
    }

    [TestMethod]
    public void SetOnesDigit_SetsValueOfOnesDigit_Void()
    {
      IntToTranslate newTranslation = new IntToTranslate(3);
      int updatedOnesDigit = 5;
      newTranslation.OnesDigit = updatedOnesDigit;
      Assert.AreEqual(updatedOnesDigit, newTranslation.OnesDigit);
    }

    [TestMethod]
    public void OnesDigitToWords_ReturnsCorrespondingText_String()
    {
      IntToTranslate threeAsNumber = new IntToTranslate(3);
      string returnedText = threeAsNumber.NumberToText();
      Assert.AreEqual("three", returnedText);
    }

    [TestMethod]
    public void FiveNumberToWord_ReturnsTextFive_String()
    {
      IntToTranslate fiveAsNumber = new IntToTranslate(5);
      string returnedText = fiveAsNumber.NumberToText();
      Assert.AreEqual("five", returnedText);
    }
  }
}