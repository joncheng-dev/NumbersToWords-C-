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
      Translation newTranslation = new Translation();
      Assert.AreEqual(typeof(Translation), newTranslation.GetType());
    }
  }
}