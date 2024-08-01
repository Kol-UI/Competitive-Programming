// Student Attendance Record II


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.StudentAttendanceRecordII
{
    public class Solution
    {
        int[,,]? dp;
        int mod = 1000000007;

        public int CheckRecord(int n)
        {
            dp = new int[n + 1, 2, 3];
            return Solve(n, 0, 0);
        }

        int Solve(int n, int a, int l)
        {
            if (a > 1 || l > 2)
                return 0;
            else if (n == 0)
                return 1;

            if (dp![n, a, l] != 0)
                return dp[n, a, l];
            int res = 0;
            
            res = (res+Solve(n - 1, a + 1, 0)) % mod;
            res = (res+Solve(n - 1, a, l + 1)) % mod;
            res = (res+Solve(n - 1, a , 0)) % mod;

            return dp[n, a, l] = res;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("552");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}