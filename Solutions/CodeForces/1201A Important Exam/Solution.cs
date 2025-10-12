// Important Exam
namespace CompetitiveProgramming.CodeForces.ImportatExam;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8601

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);
        
        string[] words = new string[n];
        for (int i = 0; i < n; i++)
        {
            words[i] = Console.ReadLine();
        }
        
        int[] points = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        long totalScore = 0;
        for (int column = 0; column < m; column++)
        {
            int[] frequency = new int[5];
            for (int row = 0; row < n; row++)
            {
                frequency[words[row][column] - 'A']++;
            }
            int maxFrequency = frequency.Max();
            totalScore += (long)points[column] * maxFrequency;
        }
        
        Console.WriteLine(totalScore);
    }
}

#pragma warning restore CS8601
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Important Exam");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}