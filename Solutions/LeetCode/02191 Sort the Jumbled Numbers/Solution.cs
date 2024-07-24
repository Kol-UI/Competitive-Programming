// Sort the Jumbled Numbers

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SorttheJumbledNumbers
{
    /*
    public class Solution
    {
        public int[] SortJumbled(int[] mapping, int[] nums)
        {
            var map = new SortedDictionary<int, List<int>>();
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                int key = 0;
                foreach (var ch in nums[i].ToString())
                    key = (key * 10) + mapping[ch - '0'];

                if(!map.ContainsKey(key)) map.Add(key, [nums[i]]);
                else map[key].Add(nums[i]);
            }
            int index = 0;
            foreach (var list in map.SelectMany(pair => pair.Value))
                nums[index++] = list;

            return nums;
        }
    }
    */
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort the Jumbled Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}