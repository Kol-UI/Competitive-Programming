// Convert a Number to Hexadecimal

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ConvertaNumbertoHexadecimal
{
    public class Solution 
    {
        private const string hex = "0123456789abcdef";

        public string ToHex(int num) 
        {
            if (num == 0)
                return "0";

            var result = new StringBuilder();
            var n = num > 0 ? num : ((long)2 << 31) + num;
            
            while (n > 0)
            {
                result.Insert(0, hex[(int)(n % 16)]);
                n /= 16;
            }

            return result.ToString();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Convert a Number to Hexadecimal");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}