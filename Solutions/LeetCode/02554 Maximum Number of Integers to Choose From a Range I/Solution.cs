// Maximum Number of Integers to Choose From a Range I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofIntegerstoChooseFromaRangeI
{
    public class Solution
    {
        public int MaxCount(int[] banned, int n, int maxSum)
        {
            int sum  = 0;
            int count = 0;
            HashSet<int> set = new(banned);

            for(int i = 1; i <= n; i++)
            {
                if(set.Contains(i))
                {
                    continue;
                }

                sum += i;

                if(sum > maxSum) break;

                count++;
            }

            return count;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Number of Integers to Choose From a Range I");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}