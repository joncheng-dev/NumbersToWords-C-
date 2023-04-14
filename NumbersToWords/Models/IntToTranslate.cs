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
    public void NumberSplitter()
    {
      List<double> temporaryList = new List<double>();

      double sum = 0;
      int userInputInteger = int.Parse(UserInput);

      for (int i = 0; i < UserInput.Length; i++) 
      {
        double result = userInputInteger % (Math.Pow(10, i + 1)) - sum;
        sum += result;

        if (result != 0) 
        {
          temporaryList.Insert(0, result);
        }
      }

      PartitionedValues = temporaryList;
    }

    // Method to translate numbers to numerated form.
    public void GiveNumeratedForm()
    {
      List<string> temporaryList = new List<string>();

      // Loops through each item of List. 
      // Finds value in dictionary.
      // Concatenates to string.
      for (int i = 0; i < PartitionedValues.Count; i++)
      {
        if (PartitionedValues[i] >= 10000)
        {
          foreach(var item in tenThousandsTranslation)
          {
            if(item.Key == PartitionedValues[i + 1])
            {
              temporaryList.Add(item.Value);
            }              
          }
          foreach(var item in tenThousandsTranslationSpecific)
          {
            if(item.Key == PartitionedValues[i + 1])
            {
              temporaryList.Add(item.Value);
            }              
          }          
        } else
        {
          foreach(var item in thousandsTranslation)
          {
            if(item.Key == PartitionedValues[i])
            {
              temporaryList.Add(item.Value);
            }
          }
        }

        foreach(var item in hundredsTranslation)
        {
          if(item.Key == PartitionedValues[i])
          {
            temporaryList.Add(item.Value);
          }
        }

        if (PartitionedValues[i] == 10)
        {
          foreach(var item in tensTranslationSpecific)
          {
            if(item.Key == PartitionedValues[i + 1])
            {
              temporaryList.Add(item.Value);
            }              
          }
          break;
        } else 
        {
          foreach(var item in tensTranslation)
          {
            if(item.Key == PartitionedValues[i])
            {
              temporaryList.Add(item.Value);
            }
          }
          foreach(var item in onesTranslation)
          {
            if(item.Key == PartitionedValues[i])
            {
              temporaryList.Add(item.Value);
            }
          }
        }
      }

      // Sets Numerated field in object
      // Numerated = completedNumeratedForm;
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
      { 0, "ten"},
      { 1, "eleven" },
      { 2, "twelve" },
      { 3, "thirteen" },
      { 4, "fourteen" },
      { 5, "fifteen" },
      { 6, "sixteen" },
      { 7, "seventeen" },
      { 8, "eighteen" },
      { 9, "nineteen" },
    };

    Dictionary<int, string> hundredsTranslation = new Dictionary<int, string>()
    {
      { 100, "one hundred"},
      { 200, "two hundred"},
      { 300, "three hundred"},
      { 400, "four hundred"},
      { 500, "five hundred"},
      { 600, "six hundred"},
      { 700, "seven hundred"},
      { 800, "eight hundred"},
      { 900, "nine hundred"},
    };

    Dictionary<int, string> thousandsTranslation = new Dictionary<int, string>()
    {
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
      { 20000, "twenty thousand"},
      { 30000, "thirty thousand"},
      { 40000, "forty thousand"},
      { 50000, "fifty thousand"},
      { 60000, "sixty thousand"},
      { 70000, "seventy thousand"},
      { 80000, "eighty thousand"},
      { 90000, "ninety thousand"},
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
