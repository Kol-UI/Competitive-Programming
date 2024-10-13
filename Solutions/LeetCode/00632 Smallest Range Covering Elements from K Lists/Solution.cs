// Smallest Range Covering Elements from K Lists

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SmallestRangeCoveringElementsfromKLists
{
    public class Solution
    {
        public int[] SmallestRange(IList<IList<int>> nums)
        {
            var resMin = nums.Min(x => x[0]);
            var resMax = nums.Max(x => x.Last());
            var max = nums.Max(x => x.Last());
            var min = resMin;
            var list = new List<int>();
            foreach (var item in nums)
                foreach (var num in item)
                    list.Add(num);
            list = list.Distinct().OrderBy(x => x).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if (Valid(min, list[i]))
                {
                    if (resMax - resMin > list[i] - min)
                    {
                        resMin = min;
                        resMax = list[i];
                    }
                    var index = list.IndexOf(min);
                    if (index < list.Count() - 1)
                        min = list[index + 1];
                    else
                        break;
                    i--;
                }
            }

            return new int[] { resMin, resMax };

            bool Valid(int start, int end)
            {
                foreach (var item in nums)
                    if (!item.Any(x => x >= start && x <= end))
                        return false;
                return true;
            }
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Smallest Range Covering Elements from K Lists");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}