using System; 
using System.Collections.Generic;

// Business logic
namespace NumbersToWords.Models
{
  public class Numbers
  {
    // UserInput private field with public get / set 
    private string _userInput;
    public string UserInput
    {
      get { return _userInput; }
      set { _userInput = value; }
    }

    // PartitionedValues, an Auto-Implemented Property
    public List<double> PartitionedValues { get; set; }

    // Numerated, an Auto-Implemented Property
    public string Numerated { get; set; }

    // Constructors - Overloaded
    public Numbers(string text1)
    {
      _userInput = text1;
    }
    public Numbers(string text1, List<double> list1)
    {
      _userInput = text1;
      PartitionedValues = list1;
    }
    public Numbers(string text1, List<double> list1, string text2)
    {
      _userInput = text1;
      PartitionedValues = list1;
      Numerated = text2;
    }

    // Method to Split User Entered Number into Partitions
    public List<double> NumberSplitter()
    {
      this.PartitionedValues.Add(10);
      this.PartitionedValues.Add(1);
      return this.PartitionedValues;
    }

    // // Translators
    // Dictionary<int, string> onesTranslation = new Dictionary<int, string>()
    // {
    //   { 1, "one" },
    //   { 2, "two" },
    //   { 3, "three" },
    //   { 4, "four" },
    //   { 5, "five" },
    //   { 6, "six" },
    //   { 7, "seven" },
    //   { 8, "eight" },
    //   { 9, "nine" },
    // };

    // Dictionary<int, string> tensTranslation = new Dictionary<int, string>()
    // {
    //   { 10, "ten" },
    //   { 11, "eleven" },
    //   { 12, "twelve" },
    //   { 13, "thirteen" },
    //   { 14, "fourteen" },
    //   { 15, "fifteen" },
    //   { 16, "sixteen" },
    //   { 17, "seventeen" },
    //   { 18, "eighteen" },
    //   { 19, "nineteen" },
    // };



    // SAVE METHOD HERE FOR LATER (NumberSplitter)
      // double sum = 0;
      // int userInputInteger = int.Parse(UserInput);

      // for (int i = 0; i < UserInput.Length; i++) 
      // {
      //   double result = userInputInteger % (Math.Pow(10, i + 1)) - sum;
      //   sum += result;

      //   if (result != 0) 
      //   {
      //     PartitionedValues.Insert(0, result);
      //   }
      // }
            
      // foreach (int entry in this.PartitionedValues)
      // {
      //   Console.WriteLine(entry);
      // }
      
      // return this.PartitionedValues;
  }
}
