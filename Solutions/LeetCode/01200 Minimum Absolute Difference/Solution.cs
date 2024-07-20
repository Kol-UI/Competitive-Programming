// Minimum Absolute Difference

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumAbsoluteDifference
{
    public class Solution
    {
        public IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            Array.Sort(arr);
            var min = Int32.MaxValue;
            var lst = new List<IList<int>>();
            for (int i = 1; i < arr.Count(); i++)
                min = Math.Min(min, arr[i] - arr[i - 1]);
            
            for (int i = 1; i < arr.Count(); i++)
                if (arr[i] - arr[i - 1] == min)
                    lst.Add(new List<int> { arr[i - 1], arr[i] });
            
            return lst;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Absolute Difference");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}