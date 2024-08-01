// Minimum Difficulty of a Job Schedule


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumDifficultyofaJobSchedule
{
    public class Solution
    {
        public static int MinDifficulty(int[] jobDifficulty, int d)
        {
            var dic = new Dictionary<(int index, int d), int>();
            return MinDifficulty((0, d), dic, jobDifficulty);
        }

        private static int MinDifficulty((int index, int d) key, Dictionary<(int index, int d), int> dic, int[] jobDifficulty)
        {
            if (dic.ContainsKey(key)) return dic[key];

            if (key.index + key.d > jobDifficulty.Length) return -1;

            var result = int.MaxValue;
            var max = jobDifficulty[key.index];
            
            if (key.d - 1 > 0)
            {
                for (int i = key.index; i < jobDifficulty.Length + 1 - key.d; i++)
                {
                    max = Math.Max(max, jobDifficulty[i]);
                    var result0 = MinDifficulty((i + 1, key.d - 1), dic, jobDifficulty);
                    if (result0 != -1)
                    {
                        result0 += max;
                        result = Math.Min(result, result0);
                    }
                    else
                    {
                        result = -1;
                    }
                }
            }
            else
            {
                for (int i = key.index; i < jobDifficulty.Length; i++)
                {
                    max = Math.Max(max, jobDifficulty[i]);
                }
                result = max;
            }

            if (!dic.ContainsKey(key)) dic.Add(key, result);

            return result;
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinDifficulty(new int[] {6,5,4,3,2,1}, 2), 7),
                ResultTester.CheckResult<int>(Solution.MinDifficulty(new int[] {9,9,9}, 4), -1),
                ResultTester.CheckResult<int>(Solution.MinDifficulty(new int[] {1,1,1}, 3), 3),
            };
            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Difficulty of a Job Schedule");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}