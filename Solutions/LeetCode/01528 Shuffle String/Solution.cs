// Shuffle String

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShuffleString
{
    public class Solution
    {
        public static string RestoreString(string s, int[] indices)
        {
            int i = 0;
            return string.Concat(s.OrderBy(ch => indices[i++]));
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.RestoreString("codeleet", new int[]{4,5,6,7,0,2,1,3}), "leetcode"),
                ResultTester.CheckResult<string>(Solution.RestoreString("abc", new int[]{0,1,2}), "abc"),
            };
            return results;
        }
    }
}