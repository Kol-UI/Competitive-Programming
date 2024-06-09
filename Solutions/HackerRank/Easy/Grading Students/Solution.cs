// Grading Students


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.GradientStudents
{
    class Result
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> roundedGrades = new List<int>();

            foreach (int grade in grades)
            {
                if (grade < 38 || grade % 5 < 3)
                {
                    roundedGrades.Add(grade);
                }
                else
                {
                    int nextMultipleOfFive = (grade / 5 + 1) * 5;
                    roundedGrades.Add(nextMultipleOfFive);
                }
            }

            return roundedGrades;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
             List<int> testGrades1 = new List<int> { 73, 67, 38, 33 };
            List<int> expectedOutput1 = new List<int> { 75, 67, 40, 33 };

            List<int> testGrades2 = new List<int> { 55, 85, 44, 59, 60 };
            List<int> expectedOutput2 = new List<int> { 55, 85, 45, 60, 60 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<List<int>>(Result.gradingStudents(testGrades1), expectedOutput1),
                ResultTester.CheckResult<List<int>>(Result.gradingStudents(testGrades2), expectedOutput2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Grading Students");
            ResultTester.CheckCurrentSolution(ProblemOrigin.HackerRank, ProblemCategory.EasyHR, Test.TestCases());
        }
    }
}