// Word

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CodeForces.Word;
class Program
{
    //static void Main()
    static void Solution()
    {
        string word = Console.ReadLine()!;
        int upperCaseCount = 0;
        int lowerCaseCount = 0;

        foreach (char c in word)
        {
            if (char.IsUpper(c))
            {
                upperCaseCount++;
            }
            else
            {
                lowerCaseCount++;
            }
        }

        string result = upperCaseCount > lowerCaseCount ? word.ToUpper() : word.ToLower();
        Console.WriteLine(result);
    }
}

public class Test
{
    public static string SolutionTest(string word)
    {
        int upperCaseCount = 0;
        int lowerCaseCount = 0;

        foreach (char c in word)
        {
            if (char.IsUpper(c))
            {
                upperCaseCount++;
            }
            else
            {
                lowerCaseCount++;
            }
        }

        return upperCaseCount > lowerCaseCount ? word.ToUpper() : word.ToLower();
    }

    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<string>(SolutionTest("aBcDeF"), "abcdef"),
            ResultTester.CheckResult<string>(SolutionTest("HELLO"), "HELLO"),
            ResultTester.CheckResult<string>(SolutionTest("CodeForces"), "codeforces"),
            ResultTester.CheckResult<string>(SolutionTest("12345"), "12345"),
            ResultTester.CheckResult<string>(SolutionTest(""), ""),
            ResultTester.CheckResult<string>(SolutionTest("AbCdEfG"), "ABCDEFG"),
            ResultTester.CheckResult<string>(SolutionTest("xyzXYZ"), "xyzxyz"),
            ResultTester.CheckResult<string>(SolutionTest("aAaAaA"), "aaaaaa"),
            ResultTester.CheckResult<string>(SolutionTest("BaBaBa"), "bababa"),
            ResultTester.CheckResult<string>(SolutionTest("aA1bB2cC3"), "aa1bb2cc3"),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CodeForces, ProblemCategory.CF800, Test.TestCases());
    }
}