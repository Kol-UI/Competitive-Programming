// Non-Substring Subsequence
namespace CompetitiveProgramming.CodeForces.NonSubstringSubsequence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string[] firstLine = Console.ReadLine().Split();
            int stringLength = int.Parse(firstLine[0]);
            int queryCount = int.Parse(firstLine[1]);
            string text = Console.ReadLine()!;
            
            for (int query = 0; query < queryCount; query++)
            {
                string[] queryData = Console.ReadLine().Split();
                int left = int.Parse(queryData[0]) - 1;
                int right = int.Parse(queryData[1]) - 1;
                
                char firstChar = text[left];
                char lastChar = text[right];
                bool isPossible = false;
                
                for (int position = 0; position < left && !isPossible; position++)
                {
                    if (text[position] == firstChar)
                    {
                        isPossible = true;
                    }
                }
                
                for (int position = right + 1; position < text.Length && !isPossible; position++)
                {
                    if (text[position] == lastChar)
                    {
                        isPossible = true;
                    }
                }
                
                Console.WriteLine(isPossible ? "YES" : "NO");
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Non-Substring Subsequence");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}