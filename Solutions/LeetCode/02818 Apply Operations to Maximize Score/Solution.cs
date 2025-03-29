// Apply Operations to Maximize Score
namespace CompetitiveProgramming.LeetCode.ApplyOperationstoMaximizeScore;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    const int MOD = 1000000007;
    
    public int MaximumScore(IList<int> nums, int k) {
        int n = nums.Count;
        int[] numArr = new int[n];
        nums.CopyTo(numArr, 0);
        int maxNum = numArr.Max();
        
        int[] primeScores = PrimeScores(maxNum);
        int[] primes = numArr.Select(x => primeScores[x]).ToArray();
        
        int[] left = new int[n];
        int[] right = new int[n];
        int[] stack = new int[n];
        
        int stackPtr = -1;
        for (int i = 0; i < n; i++) {
            while (stackPtr >= 0 && primes[stack[stackPtr]] < primes[i])
                stackPtr--;
            
            left[i] = stackPtr == -1 ? i + 1 : i - stack[stackPtr];
            stack[++stackPtr] = i;
        }
        
        stackPtr = -1;
        for (int i = n - 1; i >= 0; i--) {
            while (stackPtr >= 0 && primes[stack[stackPtr]] <= primes[i])
                stackPtr--;
            
            right[i] = stackPtr == -1 ? n - i : stack[stackPtr] - i;
            stack[++stackPtr] = i;
        }
        
        var elements = new (int value, long freq)[n];
        for (int i = 0; i < n; i++) {
            elements[i] = (numArr[i], (long)left[i] * right[i]);
        }
        Array.Sort(elements, (a, b) => b.value.CompareTo(a.value));
        
        long result = 1;
        int idx = 0;
        while (k > 0 && idx < n) {
            long take = Math.Min(elements[idx].freq, k);
            result = result * ModPow(elements[idx].value, take, MOD) % MOD;
            k -= (int)take;
            idx++;
        }
        
        return (int)result;
    }
    
    private int[] PrimeScores(int max) {
        int[] scores = new int[max + 1];
        for (int i = 2; i <= max; i++) {
            if (scores[i] != 0) continue;
            for (int j = i; j <= max; j += i) {
                scores[j]++;
            }
        }
        return scores;
    }
    
    private long ModPow(long b, long exp, int mod) {
        long result = 1;
        b %= mod;
        while (exp > 0) {
            if ((exp & 1) == 1)
                result = result * b % mod;
            b = b * b % mod;
            exp >>= 1;
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alphabetic Removals");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}