// Abbreviate a Two Word Name

/*
Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.

It should look like this:

Sam Harris => S.H

patrick feeney => P.F
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeWars.EightKyu.AbbreviateaTwoWordName
{
    public class Solution 
    {
        public static string AbbrevName(string name)
        {
            string[] words = name.Split(' ');
            string initials = $"{char.ToUpper(words[0][0])}.{char.ToUpper(words[1][0])}";
            return initials;
        }

        public static string AbbrevNameOneLiner(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();

        public static string AbbrevNameToUpper(string name)
        {
            string[] buf = name.Split(' ');

            var firstName = buf.First();
            var lastName = buf.Last();

            var oneUpper = Char.ToUpper(firstName.First());
            var twoUpper = Char.ToUpper(lastName.First());

            return $"{oneUpper}.{twoUpper}";
        }

        public static bool[] TestAbbreviateaTwoWordName()
        {
            string expected1 = "S.H"; string case1 = "Sam Harris";
            string expected2 = "P.F"; string case2 = "Patrick Feenan";
            string expected3 = "E.C"; string case3 = "Evan Cole";
            string expected4 = "P.F"; string case4 = "P Favuzzi";
            string expected5 = "D.M"; string case5 = "David Mendieta";
            string expected6 = "G.C"; string case6 = "george clooney";
            string expected7 = "M.M"; string case7 = "marky mark";
            string expected8 = "E.D"; string case8 = "eliza doolittle";
            string expected9 = "R.W"; string case9 = "reese witherspoon";

            List<(string testCase, string expected)> testCases = new List<(string, string)>
            {
                (case1, expected1), (case2, expected2), (case3, expected3), (case4, expected4), (case5, expected5), (case6, expected6), (case7, expected7),
                (case8, expected8), (case9, expected9),
            };

            List<bool> results = new List<bool>();
            foreach (var (testCase, expected) in testCases)
            {
                string result = AbbrevName(testCase);
                bool isTestPassed = ResultTester.CheckResult<string>(result, expected);
                results.Add(isTestPassed);
            }

            foreach (var (testCase, expected) in testCases)
            {
                string result = AbbrevNameOneLiner(testCase);
                bool isTestPassed = ResultTester.CheckResult<string>(result, expected);
                results.Add(isTestPassed);
            }

            foreach (var (testCase, expected) in testCases)
            {
                string result = AbbrevNameToUpper(testCase);
                bool isTestPassed = ResultTester.CheckResult<string>(result, expected);
                results.Add(isTestPassed);
            }

            return results.ToArray();
        }

    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Abbreviate a Two Word Name");
            ResultTester.CheckCurrentSolution(ProblemOrigin.CodeWars, ProblemCategory.EightKyu, Solution.TestAbbreviateaTwoWordName());
        }
    }
}