// Boats to Save People

using System;
namespace CompetitiveProgramming.LeetCode.BoatstoSavePeople
{
    /*
    You are given an array people where people[i] is the weight of the ith person, and an infinite number of boats where each boat can carry a maximum weight of limit. Each boat carries at most two people at the same time, provided the sum of the weight of those people is at most limit.
    Return the minimum number of boats to carry every given person.
    Example 1:

    Input: people = [1,2], limit = 3
    Output: 1
    Explanation: 1 boat (1, 2)
    Example 2:

    Input: people = [3,2,2,1], limit = 3
    Output: 3
    Explanation: 3 boats (1, 2), (2) and (3)
    Example 3:

    Input: people = [3,5,3,4], limit = 5
    Output: 4
    Explanation: 4 boats (3), (3), (4), (5)
    */

    public class Solution
    {
        // 2 Pointers Solution
        public static int NumRescueBoats(int[] people, int limit)
        {
            var sortedList = people.OrderBy(x => x).ToArray();
            var boats = 0;
            var lightest = 0;
            var heaviest = sortedList.Length - 1;

            while (lightest <= heaviest)
            {
                if (sortedList[lightest] + sortedList[heaviest] <= limit)
                {
                    lightest++;
                }
                heaviest--;
                ++boats;
            }
            
            return boats;
        }

        // Array Solution (Better Perf)
        public static int NumRescueBoats2(int[] people, int limit)
        {
            Array.Sort(people);

            int left = 0;
            int boats = 0;
            int right = people.Length - 1;
            while(left <= right)
            {
                if (people[left] + people[right] <= limit)
                {
                    left++;
                }
                right--;
                boats++;
            }
            return boats;
        }
    }


}