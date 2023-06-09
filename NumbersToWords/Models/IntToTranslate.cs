using System; 
using System.Collections.Generic;
using System.Linq;

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

    // NumeratedTriplets, an Auto-Implemented Property
    public List<string> NumeratedTriplets { get; set; }

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
    public Numbers(string text1, List<string> list1, List<string> list2)
    {
      _userInput = text1;
      PartitionedValues = list1;
      NumeratedTriplets = list2;
    } 

    // Method to Split User Entered Number into Partitions
    public void NumberSplitter()
    {
      // temporary list to hold elements before transferring to object. 
      List<string> tempList = new List<string>();
      string remainingString = UserInput;
      string finalThree;

      if(remainingString.Length > 3)
      {
        do
        {
          finalThree = remainingString.Substring(remainingString.Length - 3);        
          tempList.Insert(0, finalThree);
          remainingString = remainingString.Substring(0, remainingString.Length - 3);
        }
        while (remainingString.Length > 3);
      }

      if (remainingString.Length == 3)
      {
        tempList.Insert(0, remainingString);
      }
      else if (remainingString.Length == 2)
      {
        tempList.Insert(0, "0" + remainingString);        
      } 
      else if (remainingString.Length == 1)
      {
        tempList.Insert(0, "00" + remainingString);          
      }
      // Transfers list contents to Object.
      PartitionedValues = tempList;
    }

    // Function - Separates triplet into place values
    public static List<char> TripletIntoPlaceValues(string triplet)
    {
      // List holding the digits separated into place
      List<char> digitsIntoPlaceValue = new List<char>();
      // Digits separated into a character list
      for (int i = 0; i < triplet.Length; i++)
      {
        digitsIntoPlaceValue.Add(triplet[i]);
      }

      return digitsIntoPlaceValue;
    } 

    public static string GiveNumeratedTriplet(List<char> tripletIntoPlaceValues)
    {
      // List holding the numerated numbers as text
      List<string> numeratedToText = new List<string>();
      string textResult = "";

      foreach(var item in Numbers.hundredsTranslation)
      {
        if (item.Key == tripletIntoPlaceValues[0]) 
        {
          numeratedToText.Add(item.Value);
        }
      }
      foreach(var item in Numbers.tensTranslation)
      {
        if (item.Key == tripletIntoPlaceValues[1])
        {
          numeratedToText.Add(item.Value);
        }
      }

      if (tripletIntoPlaceValues[1] == '1')
      {
        foreach(var item in Numbers.tensTranslationSpecific)
        {
          if (item.Key == tripletIntoPlaceValues[2])
          {
            numeratedToText.Add(item.Value);
          }
        }
      } 
      else 
      {
        foreach(var item in Numbers.onesTranslation)
        {
          if (item.Key == tripletIntoPlaceValues[2])
          {
            numeratedToText.Add(item.Value);
          }
        }
      }

      for (int i = 0; i < numeratedToText.Count; i++)
      {
        textResult += numeratedToText[i];
        if (i + 1 != numeratedToText.Count)
        {
          textResult += " ";
        }
      }

      return textResult;
    }

    public string GiveNumeratedUserInput()
    {
      List<string> tempList = new List<string>();
      for (int i = 0; i < PartitionedValues.Count; i++)
      {
        List<char> inputTriplet = Numbers.TripletIntoPlaceValues(PartitionedValues[i]);
        string result = Numbers.GiveNumeratedTriplet(inputTriplet);
        // GiveNumeratedTriplet(entered List)
        // creates numerated string of triplet;
        tempList.Add(result);
      }
      NumeratedTriplets = tempList;

      string concatenatedUserInput = "";
      // Variable holding Key for adding suffixes
      int suffixKeyCounter = 9;
      for (int j = 0; j < NumeratedTriplets.Count; j++)
      {
        // Adds numerated triplet
        concatenatedUserInput += NumeratedTriplets[j];
        // Adds space to end if needed        
        if (j < NumeratedTriplets.Count - 1)
        {
          // if (j < NumeratedTriplets.Count)
          // {
            concatenatedUserInput += " ";
          // }
        }
        // Adds suffix if applicable
        switch(NumeratedTriplets.Count)
        {
          case 5:
            suffixKeyCounter = 0 + j;
            break;
          case 4:
            suffixKeyCounter = 1 + j;
            break;
          case 3:
            suffixKeyCounter = 2 + j;
            break;
          case 2:
            suffixKeyCounter = 3 + j;
            break;
          default:
            suffixKeyCounter = 9;
            break;
        }
        if (PartitionedValues[j] != "000")
        {
          Numbers.suffixes.TryGetValue(suffixKeyCounter, out string retrieved);
          concatenatedUserInput += retrieved;
        }
        // Adds space to end if needed
        if (j < NumeratedTriplets.Count - 1)
        {
          if (PartitionedValues[j] != "000" && PartitionedValues[j + 1] != "000")
          {
            concatenatedUserInput += " ";
          }
        }
      }      
      return concatenatedUserInput;
    }

    // Translators
    static Dictionary<char, string> onesTranslation = new Dictionary<char, string>()
    {
      // { '0', "zero" },
      { '1', "one" },
      { '2', "two" },
      { '3', "three" },
      { '4', "four" },
      { '5', "five" },
      { '6', "six" },
      { '7', "seven" },
      { '8', "eight" },
      { '9', "nine" },
    };

    static Dictionary<char, string> tensTranslation = new Dictionary<char, string>()
    {
      // { '0', "zero"},
      { '2', "twenty"},
      { '3', "thirty"},
      { '4', "forty"},
      { '5', "fifty"},
      { '6', "sixty"},
      { '7', "seventy"},
      { '8', "eighty"},
      { '9', "ninety"},
    };

    static Dictionary<char, string> tensTranslationSpecific = new Dictionary<char, string>()
    {
      { '0', "ten"},
      { '1', "eleven" },
      { '2', "twelve" },
      { '3', "thirteen" },
      { '4', "fourteen" },
      { '5', "fifteen" },
      { '6', "sixteen" },
      { '7', "seventeen" },
      { '8', "eighteen" },
      { '9', "nineteen" },
    };

    static Dictionary<char, string> hundredsTranslation = new Dictionary<char, string>()
    {
      // { '0', "zero"},
      { '1', "one hundred"},
      { '2', "two hundred"},
      { '3', "three hundred"},
      { '4', "four hundred"},
      { '5', "five hundred"},
      { '6', "six hundred"},
      { '7', "seven hundred"},
      { '8', "eight hundred"},
      { '9', "nine hundred"},
    };

    static Dictionary<int, string> suffixes = new Dictionary<int, string>()
    {
      {0, "trillion"},
      {1, "billion"},
      {2, "million"},
      {3, "thousand"},
    };
  }
}