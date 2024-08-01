// Number of 1 Bits

/*
Write a function that takes the binary representation of an unsigned integer and returns the number of '1' bits it has (also known as the Hamming weight).

Note:

Note that in some languages, such as Java, there is no unsigned integer type. In this case, the input will be given as a signed integer type. It should not affect your implementation, as the integer's internal binary representation is the same, whether it is signed or unsigned.
In Java, the compiler represents the signed integers using 2's complement notation. Therefore, in Example 3, the input represents the signed integer. -3.
 

Example 1:

Input: n = 00000000000000000000000000001011
Output: 3
Explanation: The input binary string 00000000000000000000000000001011 has a total of three '1' bits.

Example 2:

Input: n = 00000000000000000000000010000000
Output: 1
Explanation: The input binary string 00000000000000000000000010000000 has a total of one '1' bit.

Example 3:

Input: n = 11111111111111111111111111111101
Output: 31
Explanation: The input binary string 11111111111111111111111111111101 has a total of thirty one '1' bits.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Numberof1Bits
{
    public class Solution
    {
        public static int HammingWeight(uint n)
        {
            uint c = 0;

            while(n > 0)
            {
                c += n & 1;
                n >>= 1;
            }

            return (int) c;
        }
        // LINQ
        public static int HammingWeight2(uint n) => Convert.ToString(n, 2).Count(x => x == '1');
    }

    public class Test
    {
        public static bool[] TestNumberof1Bits()
        {
            uint test1 = 00000000000000000000000000001011;
            uint test2 = 00000000000000000000000010000000;

            int result1 = LeetCode.Numberof1Bits.Solution.HammingWeight(test1);
            int result2 = LeetCode.Numberof1Bits.Solution.HammingWeight(test2);
            int result1Linq = LeetCode.Numberof1Bits.Solution.HammingWeight2(test1);
            int result2Linq = LeetCode.Numberof1Bits.Solution.HammingWeight2(test2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 8),
                ResultTester.CheckResult<int>(result2, 8),
                ResultTester.CheckResult<int>(result1Linq, 8),
                ResultTester.CheckResult<int>(result2Linq, 8)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of 1 Bits");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestNumberof1Bits());
        }
    }
}