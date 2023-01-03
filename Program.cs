using System;
using System.Collections.Generic;

namespace Heliocentric
{
  class Program
  {
    static void Main(string[] args)
    {
      var input = GetInput();

      foreach (var item in input)
      {
        var lineNumber = input.IndexOf(item) + 1;
        var earthDay = Convert.ToInt32(item.Split(" ")[0]);
        var marsDay = Convert.ToInt32(item.Split(" ")[1]);

        AlignmentCalculator calculateCase = new AlignmentCalculator(earthDay, marsDay);

        string caseOutput = $"Case {lineNumber}: ";
        string result = Convert.ToString(calculateCase.DaysTillAligned);
        Console.WriteLine(caseOutput + result);
      }
    }

    private static List<string> GetInput()
    {
      string line;
      List<string> input = new List<string>();
      var inputLine = 1;
      bool isEndFile = false;
      while (inputLine <= 10 && !isEndFile)
      {
        line = Console.ReadLine();
        if (String.IsNullOrEmpty(line))
        {
          isEndFile = true;
        }
        else
        {
          input.Add(line);
          inputLine++;
        }
      }

      return input;
    }
  }
}
