// Eliminate Maximum Number of Monsters

/*
You are playing a video game where you are defending your city from a group of n monsters. You are given a 0-indexed integer array dist of size n, where dist[i] is the initial distance in kilometers of the ith monster from the city.

The monsters walk toward the city at a constant speed. The speed of each monster is given to you in an integer array speed of size n, where speed[i] is the speed of the ith monster in kilometers per minute.

You have a weapon that, once fully charged, can eliminate a single monster. However, the weapon takes one minute to charge. The weapon is fully charged at the very start.

You lose when any monster reaches your city. If a monster reaches the city at the exact moment the weapon is fully charged, it counts as a loss, and the game ends before you can use your weapon.

Return the maximum number of monsters that you can eliminate before you lose, or n if you can eliminate all the monsters before they reach the city.

 

Example 1:

Input: dist = [1,3,4], speed = [1,1,1]
Output: 3
Explanation:
In the beginning, the distances of the monsters are [1,3,4]. You eliminate the first monster.
After a minute, the distances of the monsters are [X,2,3]. You eliminate the second monster.
After a minute, the distances of the monsters are [X,X,2]. You eliminate the thrid monster.
All 3 monsters can be eliminated.

Example 2:

Input: dist = [1,1,2,3], speed = [1,1,1,1]
Output: 1
Explanation:
In the beginning, the distances of the monsters are [1,1,2,3]. You eliminate the first monster.
After a minute, the distances of the monsters are [X,0,1,2], so you lose.
You can only eliminate 1 monster.

Example 3:

Input: dist = [3,2,4], speed = [5,3,2]
Output: 1
Explanation:
In the beginning, the distances of the monsters are [3,2,4]. You eliminate the first monster.
After a minute, the distances of the monsters are [X,0,2], so you lose.
You can only eliminate 1 monster.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EliminateMaximumNumberofMonsters
{
    public class Solution
    {
        public static int EliminateMaximum(int[] dist, int[] speed)
        {
            int n = dist.Length;
            double[] cityTime = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                cityTime[i] = (double)dist[i] / speed[i];
            }
            
            Array.Sort(cityTime);
            
            for (int i = 0; i < n; i++)
            {
                if (cityTime[i] <= i)
                {
                    return i;
                }
            }
            
            return n;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] dist1 = {1,3,4};
            int[] speed1 = {1,1,1};

            int[] dist2 = {1,1,2,3};
            int[] speed2 = {1,1,1,1};

            int[] dist3 = {3,2,4};
            int[] speed3 = {5,3,2};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.EliminateMaximum(dist1, speed1), 3),
                ResultTester.CheckResult<int>(Solution.EliminateMaximum(dist2, speed2), 1),
                ResultTester.CheckResult<int>(Solution.EliminateMaximum(dist3, speed3), 1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Eliminate Maximum Number of Monsters");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}