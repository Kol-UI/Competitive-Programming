// Maximum Number of Events That Can Be Attended II

/*
ou are given an array of events where events[i] = [startDayi, endDayi, valuei]. The ith event starts at startDayi and ends at endDayi, and if you attend this event, you will receive a value of valuei. You are also given an integer k which represents the maximum number of events you can attend.

You can only attend one event at a time. If you choose to attend an event, you must attend the entire event. Note that the end day is inclusive: that is, you cannot attend two events where one of them starts and the other ends on the same day.

Return the maximum sum of values that you can receive by attending events.

 

Example 1:

Input: events = [[1,2,4],[3,4,3],[2,3,1]], k = 2
Output: 7
Explanation: Choose the green events, 0 and 1 (0-indexed) for a total value of 4 + 3 = 7.

Example 2:

Input: events = [[1,2,4],[3,4,3],[2,3,10]], k = 2
Output: 10
Explanation: Choose event 2 for a total value of 10.
Notice that you cannot attend any other event as they overlap, and that you do not have to attend k events.

Example 3:

Input: events = [[1,1,1],[2,2,2],[3,3,3],[4,4,4]], k = 3
Output: 9
Explanation: Although the events do not overlap, you can only attend 3 events. Pick the highest valued three.
*/

using System;
namespace CompetitiveProgramming.LeetCode.MaximumNumberofEventsThatCanBeAttendedII
{
    public class Solution
    {
        public static int MaxValue(int[][] events, int k)
        {
            int n = events.Length;
            events = (from x in events orderby x[0] select x).ToArray();
            
            int[,] dp = new int[n, k];

            for(int i = 0; i < n; i++)
                for(int j = 0; j < k; j++)
                    dp[i, j] = -1;

            int DP(int eventIdx, int remainingK)
            {
                if(remainingK <= 0)
                    return 0;
                if(eventIdx >= events.Length)
                    return 0;
                if(dp[eventIdx, remainingK - 1] > -1)
                    return dp[eventIdx, remainingK - 1];

                int result = 0;

                result += events[eventIdx][2];
                int nextEventIdx = eventIdx;

                while(++nextEventIdx < n && events[nextEventIdx][0] <= events[eventIdx][1]);
                result += DP(nextEventIdx, remainingK - 1);

                result = Math.Max(result, DP(eventIdx + 1, remainingK));
                dp[eventIdx, remainingK - 1] = result;
                return result;
            }
            return DP(0, k);
        }
    }
}