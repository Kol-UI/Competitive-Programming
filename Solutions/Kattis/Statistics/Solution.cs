// Statistics
namespace CompetitiveProgramming.Kattis.Statistics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string line;
        int caseNum = 1;
        
        while ((line = Console.ReadLine()) != null)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;
            
            string[] parts = line.Split();
            int n = int.Parse(parts[0]);
            
            List<int> numbers = new List<int>();
            for (int i = 1; i < parts.Length; i++)
            {
                numbers.Add(int.Parse(parts[i]));
            }
            
            while (numbers.Count < n)
            {
                string nextLine = Console.ReadLine();
                if (nextLine == null) break;
                string[] nextParts = nextLine.Split();
                foreach (string num in nextParts)
                {
                    numbers.Add(int.Parse(num));
                }
            }
            
            int min = numbers[0];
            int max = numbers[0];
            
            for (int i = 1; i < n; i++)
            {
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
            
            Console.WriteLine($"Case {caseNum}: {min} {max} {max - min}");
            caseNum++;
        }
    }
}

#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Statistics");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}