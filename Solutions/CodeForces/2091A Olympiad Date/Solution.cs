// Olympiad Date
namespace CompetitiveProgramming.CodeForces.OlympiadDate;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] counts = new int[6] { 3, 1, 2, 1, 0, 1 };
            int result = 0;
            
            int[] numbers = Console.ReadLine().Split()
                            .Select(int.Parse).ToArray();
            
            for (int i = 0; i < n; i++)
            {
                int num = numbers[i];
                if (num >= 0 && num <= 5 && counts[num] > 0)
                {
                    counts[num]--;
                    if (counts.Sum() == 0)
                    {
                        result = i + 1;
                        break;
                    }
                }
            }
            
            Console.WriteLine(result);
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
        StyleHelper.Title("Olympiad Date");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}