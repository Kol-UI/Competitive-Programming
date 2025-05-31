// Yet Another Broken Keyboard
namespace CompetitiveProgramming.CodeForces.YetAnotherBrokenKeyboard;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        var firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);
        string s = Console.ReadLine();
        
        bool[] allowed = new bool[26];
        var allowedChars = Console.ReadLine().Split();
        for (int i = 0; i < k; i++)
        {
            char c = allowedChars[i][0];
            allowed[c - 'a'] = true;
        }

        long current = 0;
        long total = 0;
        foreach (char c in s)
        {
            if (allowed[c - 'a'])
            {
                current++;
                total += current;
            }
            else
            {
                current = 0;
            }
        }
        Console.WriteLine(total);
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
        StyleHelper.Title("Yet Another Broken Keyboard");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}