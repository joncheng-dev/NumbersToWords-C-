using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords.Models;


namespace NumbersToWords.Tests
{
  [TestClass]
  public class Numbers
  {
    // Tests go here
    [TestMethod]
    public void NumbersConstructor_CreatesInstanceOfNumbers_Numbers()
    {
      Numbers newNumbers = new Numbers();
      Assert.AreEqual(typeof(Numbers), newNumbers.GetType());
    }

  }
}