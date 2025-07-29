// Smallest Subarrays With Maximum Bitwise OR
namespace CompetitiveProgramming.LeetCode.SmallestSubarraysWithMaximumBitwiseOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] SmallestSubarrays(int[] nums)
    {
        int n = nums.Length;
        int[] rightmostBitSetIndex = new int[31]; 
        Array.Fill(rightmostBitSetIndex, -1);
        int[] result = new int[n]; 

        for (int i = n - 1; i >= 0; --i)
        {
            int currentMaxReach = i; 

            for (int bit = 0; bit < 31; ++bit)
            {
                if ((nums[i] & (1 << bit)) == 0)
                {
                    if (rightmostBitSetIndex[bit] != -1)
                    {
                        currentMaxReach = Math.Max(currentMaxReach, rightmostBitSetIndex[bit]);
                    }
                }
                else
                {
                    rightmostBitSetIndex[bit] = i;
                }
            }
            result[i] = currentMaxReach - i + 1;
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Subarrays With Maximum Bitwise OR");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}