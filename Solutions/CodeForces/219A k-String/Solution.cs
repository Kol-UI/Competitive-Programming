// k-String
namespace CompetitiveProgramming.CodeForces.kString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int k = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string output = "";
        int[] letters = new int[26];
        
        foreach (char c in input)
        {
            letters[c - 'a']++;
        }
        
        for (int u = 0; u < 26; u++)
        {
            if (letters[u] == 0) continue;
            if (letters[u] % k == 0)
            {
                for (int v = 0; v < letters[u] / k; v++)
                {
                    output += (char)('a' + u);
                }
            }
            else
            {
                output = "-1";
                break;
            }
        }
        
        if (output == "-1")
        {
            Console.WriteLine(output);
        }
        else
        {
            for (int u = 0; u < k; u++)
            {
                Console.Write(output);
            }
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("k-String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}