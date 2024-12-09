// Special Array II

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SpecialArrayII
{
    public class Solution
    {
        public bool[] IsArraySpecial(int[] nums, int[][] queries)
        {
            var tempo = new int[nums.Length];
            var result = new bool[queries.Length];

            tempo[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] % 2 != nums[i-1] % 2)
                {
                    tempo[i] = tempo[i - 1] + 1;
                }
                else 
                {
                    tempo[i] = 1;
                }
            }
            
            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = (queries[i][1] - queries[i][0] + 1) <= tempo[queries[i][1]];
            }

            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Special Array II");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}