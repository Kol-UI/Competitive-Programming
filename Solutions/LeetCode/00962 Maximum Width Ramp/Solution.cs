// Maximum Width Ramp

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumWidthRamp
{
    public class Solution
    {
        public int MaxWidthRamp(int[] nums)
        {
            var result = 0;
            var starts = new List<(int Index, int Value)>();
            starts.Add((0, nums[0]));

            for (var i = 1; i < nums.Length; i++)
            {
                if (starts[^1].Value > nums[i])
                {
                    starts.Add((i, nums[i]));
                }
                else
                {
                    var start = FindStartOfRamp(nums[i]);
                    result = Math.Max(result, i - start);
                }
            }

            return result;

            int FindStartOfRamp(int num)
            {
                var left = 0;
                var right = starts.Count;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (starts[mid].Value <= num)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return starts[left].Index;
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Width Ramp");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}