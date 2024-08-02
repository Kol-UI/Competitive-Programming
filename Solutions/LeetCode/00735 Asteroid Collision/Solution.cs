// Asteroid Collision

/*
We are given an array asteroids of integers representing asteroids in a row.

For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left). Each asteroid moves at the same speed.

Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, both will explode. Two asteroids moving in the same direction will never meet.

 

Example 1:

Input: asteroids = [5,10,-5]
Output: [5,10]
Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never collide.

Example 2:

Input: asteroids = [8,-8]
Output: []
Explanation: The 8 and -8 collide exploding each other.

Example 3:

Input: asteroids = [10,2,-5]
Output: [10]
Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AsteroidCollision
{
    public class Solution
    {
        // Stack
        public static int[] AsteroidCollision(int[] asteroids) 
        {
            var stack = new List<int>(asteroids.Length);
            foreach (var asteroid in asteroids)
            {
                bool add = true;
                while (stack.Any() && stack[^1] > 0 && asteroid < 0)
                {
                    if (stack[^1] < -asteroid)
                    {
                        stack.RemoveAt(stack.Count - 1);
                        continue;
                    }

                    add = false;
                    if (stack[^1] == -asteroid)
                    {
                        stack.RemoveAt(stack.Count - 1);
                    }

                    break;
                }

                if (add)
                {
                    stack.Add(asteroid);
                }
            }

            return stack.ToArray();
        }
    }

    public class Test
    {
        public static bool[] TestAsteroidCollision()
        {
            int[] asteroids1 = {5,10,-5};
            int[] asteroids2 = {8,-8};
            int[] asteroids3 = {10,2,-5};

            int[] result1 = Solution.AsteroidCollision(asteroids1);
            int[] result2 = Solution.AsteroidCollision(asteroids2);
            int[] result3 = Solution.AsteroidCollision(asteroids3);

            int[] expected1 = {5,10};
            int[] expected2 = {};
            int[] expected3 = {10};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result1, expected1),
                ResultTester.CheckResult<int[]>(result2, expected2),
                ResultTester.CheckResult<int[]>(result3, expected3)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Asteroid Collision");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestAsteroidCollision());
        }
    }
}