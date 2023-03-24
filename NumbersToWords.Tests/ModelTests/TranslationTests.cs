using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class TranslationTests
  {
    // Tests go here
    [TestMethod]
    public void TranslationConstructor_CreatesInstanceOfTranslation_Translation()
    {
      Translation newTranslation = new Translation(2);
      Assert.AreEqual(typeof(Translation), newTranslation.GetType());
    }

    [TestMethod]
    public void GetOnesDigit_ReturnsOnesDigit_Int()
    {
      int number = 4;
      Translation newTranslation = new Translation(number);
      int result = newTranslation.OnesDigit;
      Assert.AreEqual(result, number);
    }
  }
}