// Total Characters in String After Transformations II
namespace CompetitiveProgramming.LeetCode.TotalCharactersinStringAfterTransformationsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LengthAfterTransformations(string s, int t, IList<int> nums)
    {
        const int MOD = 1_000_000_007;
        const int L = 26;

        int[,] T = new int[L, L];
        for (int i = 0; i < L; i++)
            for (int j = 1; j <= nums[i]; j++)
                T[(i + j) % L, i] = 1;

        int[,] MatrixMul(int[,] A, int[,] B)
        {
            int[,] C = new int[L, L];
            for (int i = 0; i < L; i++)
                for (int j = 0; j < L; j++)
                    for (int k = 0; k < L; k++)
                        C[i, j] = (int)((C[i, j] + (long)A[i, k] * B[k, j]) % MOD);
            return C;
        }

        int[,] MatrixPow(int[,] A, int p)
        {
            int[,] res = new int[L, L];
            for (int i = 0; i < L; i++) res[i, i] = 1;
            while (p > 0)
            {
                if ((p & 1) == 1) res = MatrixMul(res, A);
                A = MatrixMul(A, A);
                p >>= 1;
            }
            return res;
        }

        int[] f = new int[L];
        foreach (char c in s) f[c - 'a']++;

        int[,] P = MatrixPow(T, t);
        int ans = 0;

        for (int i = 0; i < L; i++)
            for (int j = 0; j < L; j++)
                ans = (int)((ans + (long)P[i, j] * f[j]) % MOD);

        return ans;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Total Characters in String After Transformations II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}