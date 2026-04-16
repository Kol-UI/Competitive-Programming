// ATM Maintenance
namespace CompetitiveProgramming.Kattis.ATMMaintenance;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

class Solution
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int k = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split();
        
        for (int i = 0; i < n; i++)
        {
            int x = int.Parse(secondLine[i]);
            if (x <= k)
            {
                k -= x;
                Console.Write("1");
            }
            else
            {
                Console.Write("0");
            }
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("ATM Maintenance");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}