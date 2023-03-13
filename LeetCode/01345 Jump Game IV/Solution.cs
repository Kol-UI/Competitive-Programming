using System;
namespace CompetitiveProgramming.LeetCode.JumpGameIV
{
    // Given an array of integers arr, you are initially positioned at the first index of the array.
    // In one step you can jump from index i to index:
    // i + 1 where: i + 1 < arr.length.
    // i - 1 where: i - 1 >= 0.
    // j where: arr[i] == arr[j] and i != j.
    // Return the minimum number of steps to reach the last index of the array.
    // Notice that you can not jump outside of the array at any time.

    // Example 1:
    // Input: arr = [100,-23,-23,404,100,23,23,23,3,404]
    // Output: 3
    // Explanation: You need three jumps from index 0 --> 4 --> 3 --> 9. Note that index 9 is the last index of the array.
    
    // Example 2:
    // Input: arr = [7]
    // Output: 0
    // Explanation: Start index is the last index. You do not need to jump.
    
    // Example 3:
    // Input: arr = [7,6,9,6,9,6,9,7]
    // Output: 1
    // Explanation: You can jump directly from index 0 to index 7 which is last index of the array.

    public class Solution
    {
        public static int MinJumps(int[] arr) 
        {
            var dic = new Dictionary<int, List<int>>();
            var visited = new bool[arr.Length];
            var queue = new Queue<int>();
            queue.Enqueue(0);
            visited[0] = true;
            var steps = 0;

            for (var i = 0; i < arr.Length; i++) 
            {
                if (!dic.ContainsKey(arr[i]))
                    dic.Add(arr[i], new List<int>());
                dic[arr[i]].Add(i);
            }

            while (queue.Count > 0) 
            {
                var count = queue.Count;
                for (var j = 0; j < count; j++) 
                {
                    var cur = queue.Dequeue();
                    if (cur == arr.Length - 1)
                        return steps;

                    if (cur - 1 >= 0 && !visited[cur - 1])
                    {
                        queue.Enqueue(cur - 1);
                        visited[cur - 1] = true;
                    }

                    if (cur + 1 < arr.Length && !visited[cur + 1])
                    {
                        queue.Enqueue(cur + 1);
                        visited[cur + 1] = true;
                    }

                    if (dic.ContainsKey(arr[cur]))
                    {
                        foreach (var index in dic[arr[cur]])
                        {
                            if (visited[index]) continue;
                            queue.Enqueue(index);
                            visited[index] = true;
                        }
                        dic.Remove(arr[cur]);
                    }
                }
                steps++;  
            }
            return -1;
        }
    }
}