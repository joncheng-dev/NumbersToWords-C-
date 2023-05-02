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
    public List<string> PartitionedValues { get; set; }

    // Numerated, an Auto-Implemented Property
    public string Numerated { get; set; }

    // Constructors - Overloaded
    public Numbers(string text1)
    {
      _userInput = text1;
    }
    public Numbers(string text1, List<string> list1)
    {
      _userInput = text1;
      PartitionedValues = list1;
    }
    public Numbers(string text1, List<string> list1, string text2)
    {
      _userInput = text1;
      PartitionedValues = list1;
      Numerated = text2;
    } 

    // Method to Split User Entered Number into Partitions
    public void NumberSplitter()
    {
      // temporary list to hold elements before transferring to object. 
      List<string> tempList = new List<string>();

      // Take user input value. Separate into triplets. Add to List.
      int numberOfDigits = UserInput.Length;
      if (numberOfDigits == 3)
      {
        tempList.Add(UserInput);        
      }   
      if (numberOfDigits == 2)
      {
        tempList.Add("0" + UserInput);        
      }      
      if (numberOfDigits == 1)
      {
        tempList.Add("00" + UserInput);        
      }
      // Transfers list contents to Object.
      PartitionedValues = tempList;
    }

    public void GiveNumeratedTriplet(string triplet)
    {
      List<string> temporaryList = new List<string>();
      
      
      foreach(var item in hundredsTranslation)
      {
        if (item.Key == triplet)
        {
          temporaryList.Add(item.Value);
        }
      }
      
      for (int i = 0; i < temporaryList.Count; i++)
      {
        Numerated += temporaryList[i];
        if (i + 1 != temporaryList.Count)
        {
          Numerated += " ";
        }
      }
    }

    // Translators
    Dictionary<int, string> onesTranslation = new Dictionary<int, string>()
    {
      { 1, "one" },
      { 2, "two" },
      { 3, "three" },
      { 4, "four" },
      { 5, "five" },
      { 6, "six" },
      { 7, "seven" },
      { 8, "eight" },
      { 9, "nine" },
    };

    Dictionary<int, string> tensTranslation = new Dictionary<int, string>()
    {
      { 20, "twenty"},
      { 30, "thirty"},
      { 40, "forty"},
      { 50, "fifty"},
      { 60, "sixty"},
      { 70, "seventy"},
      { 80, "eighty"},
      { 90, "ninety"},
    };

    Dictionary<int, string> tensTranslationSpecific = new Dictionary<int, string>()
    {
      { 10, "ten"},
      { 11, "eleven" },
      { 12, "twelve" },
      { 13, "thirteen" },
      { 14, "fourteen" },
      { 15, "fifteen" },
      { 16, "sixteen" },
      { 17, "seventeen" },
      { 18, "eighteen" },
      { 19, "nineteen" },
    };

    Dictionary<string, string> hundredsTranslation = new Dictionary<string, string>()
    {
      { "100", "one hundred"},
      { "200", "two hundred"},
      { "300", "three hundred"},
      { "400", "four hundred"},
      { "500", "five hundred"},
      { "600", "six hundred"},
      { "700", "seven hundred"},
      { "800", "eight hundred"},
      { "900", "nine hundred"},
    };

    Dictionary<int, string> thousandsTranslation = new Dictionary<int, string>()
    {
      { 0000, "thousand"},
      { 1000, "one thousand"},
      { 2000, "two thousand"},
      { 3000, "three thousand"},
      { 4000, "four thousand"},
      { 5000, "five thousand"},
      { 6000, "six thousand"},
      { 7000, "seven thousand"},
      { 8000, "eight thousand"},
      { 9000, "nine thousand"},
    };

    Dictionary<int, string> tenThousandsTranslation = new Dictionary<int, string>()
    {
      { 20000, "twenty"},
      { 30000, "thirty"},
      { 40000, "forty"},
      { 50000, "fifty"},
      { 60000, "sixty"},
      { 70000, "seventy"},
      { 80000, "eighty"},
      { 90000, "ninety"},
    };

    Dictionary<int, string> tenThousandsTranslationSpecific = new Dictionary<int, string>()
    {
      { 10000, "ten thousand"},
      { 11000, "eleven thousand"},
      { 12000, "twelve thousand"},
      { 13000, "thirteen thousand"},
      { 14000, "fourteen thousand"},
      { 15000, "fifteen thousand"},
      { 16000, "sixteen thousand"},
      { 17000, "seventeen thousand"},
      { 18000, "eighteen thousand"},
      { 19000, "nineteen thousand"},
    };

    Dictionary<int, string> hundredThousandsTranslation = new Dictionary<int, string>()
    {
      { 100000, "one hundred"},
      { 200000, "two hundred"},    
      { 300000, "three hundred"},
      { 400000, "four hundred"},
      { 500000, "five hundred"},
      { 600000, "six hundred"},
      { 700000, "seven hundred"},
      { 800000, "eight hundred"},
      { 900000, "nine hundred"},                                    
    };

    Dictionary<int, string> millionsTranslation = new Dictionary<int, string>()
    {
      { 0000000, "million"},
      { 1000000, "one million"},
      { 2000000, "two million"},
      { 3000000, "three million"},
      { 4000000, "four million"},
      { 5000000, "five million"},
      { 6000000, "six million"},
      { 7000000, "seven million"},
      { 8000000, "eight million"},
      { 9000000, "nine million"},
    };
  }
}


          // // If XXXXX without following 4 digit number following --  i.e. 9000, but has a XXX three digit number or after   
          // else if ((i + 1 < PartitionedValues.Count) && PartitionedValues[i + 1].ToString().Length != 4)
          // {
          //   foreach(var item in tenThousandsTranslation)
          //   {
          //     if (item.Key == PartitionedValues[i])
          //     {
          //       temporaryList.Add(item.Value);
          //     }
          //   }
          //   temporaryList.Add(thousandsTranslation[0000]);
          //   i++;
          // }
          // // If XXXXX without any additional numbers
          // else if (i == PartitionedValues.Count)
          // {
          //   foreach(var item in tenThousandsTranslation)
          //   {
          //     if (item.Key == PartitionedValues[i])
          //     {
          //       temporaryList.Add(item.Value);
          //     }
          //   }
          //   temporaryList.Add(thousandsTranslation[0000]);
          // } 


    // public void NumberSplitter()
    // {
    //   List<double> temporaryList = new List<double>();

    //   double sum = 0;
    //   int userInputInteger = int.Parse(UserInput);

    //   for (int i = 0; i < UserInput.Length; i++) 
    //   {
    //     double result = userInputInteger % (Math.Pow(10, i + 1)) - sum;
    //     sum += result;

    //     if (result != 0) 
    //     {
    //       temporaryList.Insert(0, result);
    //     }
    //   }

    //   PartitionedValues = temporaryList;
    // }          