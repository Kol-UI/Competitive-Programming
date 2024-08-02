// Furthest Point From Origin



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FurthestPointFromOrigin
{
    public class Solution 
    {
        public static int FurthestDistanceFromOrigin(string moves)
        {
            var data = moves.ToCharArray();
            var lenght = data.Length;
            
            var sum = 0;
            var free = 0;

            for (var i = 0; i < lenght; ++i)
            {
                var character = data[i];
                if (character == 'L')
                {
                    ++sum;
                }
                else if (character == 'R')
                {
                    --sum;
                }
                else
                {
                    ++free;
                }
            }

            return Math.Abs(sum) + free;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.FurthestDistanceFromOrigin("L_RL__R"), 3),
                ResultTester.CheckResult<int>(Solution.FurthestDistanceFromOrigin("_R__LL_"), 5),
                ResultTester.CheckResult<int>(Solution.FurthestDistanceFromOrigin("_______"), 7),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Furthest Point From Origin");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}