// Longest Square Streak in an Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestSquareStreakinanArray
{
    public class Solution
    {
        public int LongestSquareStreak(int[] nums)
        {

            HashSet<int> Set = new HashSet<int>(nums);
            int maxStreak = -1;

            List<int> sortedNums = new List<int>(Set);
            sortedNums.Sort();

            foreach (int num in sortedNums) 
            {
                int current = num;
                int count = 0;

                while (Set.Contains(current)) 
                {
                    Set.Remove(current);
                    current = current * current;
                    count++;
                }
                maxStreak = Math.Max(maxStreak, count);
            }
            return maxStreak > 1 ? maxStreak : -1;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Square Streak in an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}