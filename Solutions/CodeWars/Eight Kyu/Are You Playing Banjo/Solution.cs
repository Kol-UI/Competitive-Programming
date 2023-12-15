// Are You Playing Banjo

/*
Create a function which answers the question "Are you playing banjo?".
If your name starts with the letter "R" or lower case "r", you are playing banjo!

The function takes a name as its only argument, and returns one of the following strings:

name + " plays banjo" 
name + " does not play banjo"
Names given are always valid strings.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.AreYouPlayingBanjo
{
    public class Kata
    {
        public static string AreYouPlayingBanjo(string name)
        {
            if (name.Length > 0 && (name[0] == 'R' || name[0] == 'r'))
            {
                return name + " plays banjo";
            }
            else
            {
                return name + " does not play banjo";
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("Martin"), "Martin does not play banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("Rikke"), "Rikke plays banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("bravo"), "bravo does not play banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("Paul"), "Paul does not play banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("rolf"), "rolf plays banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("Adam"), "Adam does not play banjo"),
                ResultTester.CheckResult<string>(Kata.AreYouPlayingBanjo("Ringo"), "Ringo plays banjo"),
            };
            return results;
        }
    }
}