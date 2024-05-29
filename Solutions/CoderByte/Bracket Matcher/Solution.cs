// Bracket Matcher

/*
Have the function BracketMatcher(str) take the str parameter being passed and return 1 if the brackets are correctly matched and each one is accounted for. Otherwise return 0. For example: if str is "(hello (world))", then the output should be 1, but if str is "((hello (world))" the the output should be 0 because the brackets do not correctly match up. Only "(" and ")" will be used as brackets. If str contains no brackets return 1.
Examples
Input: "(coder)(byte))"
Output: 0
Input: "(c(oder)) b(yte)"
Output: 1
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.CoderByte.BracketMatcher;

class MainClass
{
    public static int BracketMatcher(string str)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c == '(')
            {
                count++;
            }
            else if (c == ')')
            {
                count--;
                if (count < 0)
                {
                    return 0;
                }
            }
        }

        return count == 0 ? 1 : 0;
    }

    /*
    static void Main()
    {  
        Console.WriteLine(BracketMatcher(Console.ReadLine()));
    } 
    */
}

// TEST
public class Test
{
    public static bool[] TestCases()
    {
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(MainClass.BracketMatcher("(coder)(byte))"), 0),
            ResultTester.CheckResult<int>(MainClass.BracketMatcher("(c(oder)) b(yte)"), 1),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bracket Matcher");
        ResultTester.CheckCurrentSolution(ProblemOrigin.CoderByte, ProblemCategory.MediumCB, Test.TestCases());
    }
}