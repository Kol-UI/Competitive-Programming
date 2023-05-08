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
}