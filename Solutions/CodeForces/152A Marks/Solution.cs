// Marks
namespace CompetitiveProgramming.CodeForces.Marks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int numStudents = int.Parse(input[0]);
        int numCourses = int.Parse(input[1]);
        
        int maxGrade = 0;
        bool[] successful = new bool[numStudents];
        int[] grades = new int[numStudents * numCourses];
        
        for (int n = 0; n < numStudents; n++)
        {
            string line = Console.ReadLine();
            for (int m = 0; m < numCourses; m++)
            {
                grades[n * numCourses + m] = line[m] - '0';
            }
        }
        
        for (int n = 0; n < numStudents; n++)
        {
            successful[n] = false;
        }
        
        for (int m = 0; m < numCourses; m++)
        {
            maxGrade = 0;
            for (int n = 0; n < numStudents; n++)
            {
                maxGrade = Math.Max(maxGrade, grades[n * numCourses + m]);
            }
            for (int n = 0; n < numStudents; n++)
            {
                if (grades[n * numCourses + m] == maxGrade)
                {
                    successful[n] = true;
                }
            }
        }
        
        int total = 0;
        for (int student = 0; student < numStudents; student++)
        {
            if (successful[student]) total++;
        }
        
        Console.WriteLine(total);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Marks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}