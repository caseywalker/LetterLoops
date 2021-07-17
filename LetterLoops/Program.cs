using System;

namespace LetterLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please enter a word to loop through");
      var testString = Console.ReadLine();
      var counter = 0;
      var finalString = "";

      for (var i = 0; i < testString.Length; i++)
      {
        counter++;

        for (var j = 0; j < counter; j++)
        {
          if (j == 0 && i > 0)
          {
            var first = char.ToUpper(testString[i]);
            finalString += $"-{first}";
          } 
          else
          {
            finalString += $"{testString[i]}";
          }
        }
      }
      Console.WriteLine($"{finalString}");
    }
  }
}
