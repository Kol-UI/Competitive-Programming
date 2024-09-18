// Largest Number

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LargestNumber
{
    public class Solution
    {
        public string LargestNumber(int[] nums)
        {
            var stringNums = ConvertToStringArray(nums);
            var sortedNums = SortNumbersByCustomOrder(stringNums);
            return HandleLeadingZeros(sortedNums);
        }

        private string[] ConvertToStringArray(int[] nums)
        {
            return nums.Select(num => num.ToString()).ToArray();
        }

        private string[] SortNumbersByCustomOrder(string[] stringNums)
        {
            return stringNums
                .OrderByDescending(a => a, Comparer<string>.Create(StringComparerForLargestNumber))
                .ToArray();
        }

        private int StringComparerForLargestNumber(string a, string b)
        {
            var order1 = a + b;
            var order2 = b + a;
            return string.Compare(order1, order2);
        }

        private string HandleLeadingZeros(string[] sortedNums)
        {
            var result = string.Join("", sortedNums);
            return result[0] == '0' ? "0" : result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Number");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}