// Longest Binary Subsequence Less Than or Equal to K
namespace CompetitiveProgramming.LeetCode.LongestBinarySubsequenceLessThanorEqualtoK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int LongestSubsequence(string s, int k) {
        int[] zero = new int[s.Length];
        zero[0] = (s[0] == '0' ? 1 : 0);
        for (int i = 1; i < s.Length; i++) {
            zero[i] = zero[i-1] + (s[i] == '0' ? 1 : 0);
        }
        int ksize = (int)Math.Log(k, 2) + 1;
        if (ksize > s.Length) {
            return s.Length;
        }
        int result = 0;
        for(int i = ksize - 1; i < s.Length; i++) {
            int number = GetIntFromBinary(s, i, ksize);
            int sz = number > k ? ksize - 1 : ksize;
            int compValue = sz + (i - sz < 0 ? 0 : zero[i-sz]);
            result = Math.Max(result, compValue);
        }
        return result;
    }
    private int GetIntFromBinary(string s, int pos, int size) {
        int val = 1;
        int result = 0;
        for(int i = pos; i > pos-size; i--) {
            if (s[i] == '1') {
                result += val;
            }
            val = (val << 1);
        }
        return result;
    }
    
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Longest Binary Subsequence Less Than or Equal to K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}