// Maximum Swap

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumSwap
{
    public class Solution
    {
        public int MaximumSwap(int num)
        {
            if (num == 0) return 0;
            
            var s = num.ToString();
            var sb = new StringBuilder(s);
            int maxSwappedValue = num;
            int rightMaxIndex = s.Length - 1;
            
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (s[rightMaxIndex] > s[i])
                {
                    Swap(sb, i, rightMaxIndex);
                    maxSwappedValue = Math.Max(maxSwappedValue, Convert.ToInt32(sb.ToString()));
                    Swap(sb, i, rightMaxIndex);
                }
                else if (s[rightMaxIndex] < s[i])
                {
                    rightMaxIndex = i;
                }
            }
            
            return maxSwappedValue;
        }

        private void Swap(StringBuilder sb, int i, int j)
        {
            var temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Swap");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}