// Freedom Trail


using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FreedomTrail
{
    public class Solution 
    {
        public static int FindRotateSteps(string ring, string key) 
        {
            Dictionary<string, int> memo = new Dictionary<string, int>();
            return DFS(ring, key, 0, memo);
        }

        private static int DFS(string ring, string key, int index, Dictionary<string, int> memo) 
        {
            if (index == key.Length) return 0;
            string keyRing = ring + index.ToString();
            if (memo.ContainsKey(keyRing)) return memo[keyRing];
            
            char target = key[index];
            int minSteps = int.MaxValue;
            
            for (int i = 0; i < ring.Length; i++) 
            {
                if (ring[i] == target) 
                {
                    int stepsToRotate = Math.Min(i, ring.Length - i);
                    string rotatedRing = RotateRing(ring, i);
                    int steps = stepsToRotate + 1 + DFS(rotatedRing, key, index + 1, memo);
                    minSteps = Math.Min(minSteps, steps);
                }
            }
            
            memo[keyRing] = minSteps;
            return minSteps;
        }
        
        private static string RotateRing(string ring, int steps) 
        {
            return ring.Substring(steps) + ring.Substring(0, steps);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FindRotateSteps("godding", "gd"), 4),
                ResultTester.CheckResult<int>(Solution.FindRotateSteps("godding", "godding"), 13),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("514");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}