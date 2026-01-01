// Like the Bitset
namespace CompetitiveProgramming.CodeForces.LiketheBitset;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            string[] firstLine = Console.ReadLine().Split();
            int n = int.Parse(firstLine[0]);
            int k = int.Parse(firstLine[1]);
            string s = Console.ReadLine();
            
            bool possible = true;
            int consecutiveCount = 0;
            
            for (int position = 0; possible && position < s.Length; position++)
            {
                if (s[position] == '1')
                {
                    consecutiveCount++;
                }
                else
                {
                    consecutiveCount = 0;
                }
                if (consecutiveCount >= k)
                {
                    possible = false;
                }
            }
            
            if (!possible)
            {
                Console.WriteLine("NO");
                continue;
            }
            
            Console.WriteLine("YES");
            
            int counter = 1;
            int[] result = new int[n];
            
            for (int position = 0; position < n; position++)
            {
                if (s[position] == '1')
                {
                    result[position] = counter++;
                }
            }
            
            for (int position = 0; position < n; position++)
            {
                if (result[position] == 0)
                {
                    result[position] = counter++;
                }
            }
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Like the Bitset");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}