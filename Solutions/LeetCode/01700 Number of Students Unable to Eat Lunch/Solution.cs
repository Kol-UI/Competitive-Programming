// Number of Students Unable to Eat Lunch


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofStudentsUnabletoEatLunch
{
    public class Solution
    {
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            int[] eat = new int[2];
            foreach (int student in students)
                eat[student]++;

            foreach (int sandwich in sandwiches)
            {
                if (eat[sandwich] > 0)
                    eat[sandwich]--;
                else
                    break;
            }

            return eat[0] + eat[1];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.CountStudents(new int[]{1,1,0,0}, new int[]{0,1,0,1}), 0),
                ResultTester.CheckResult<int>(Solution.CountStudents(new int[]{1,1,1,0,0,1}, new int[]{1,0,0,0,1,1}), 3),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1700");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}