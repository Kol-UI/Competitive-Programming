// The Number of Beautiful Subsets

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.TheNumberofBeautifulSubsets
{
    public class Solution {
    Dictionary<int, HashSet<int>>? numIndicesMap;
    int count;

    public int BeautifulSubsets(int[] nums, int k) {
        numIndicesMap = new();
        count = 0;
        DFS(nums, k, 0);
        return count-1;
    }

    private void DFS(int[] nums, int k, int idx){
        if(idx >= nums.Length) {
            count++;
            return;
        }

        DFS(nums, k, idx+1);

        if(!numIndicesMap!.ContainsKey(nums[idx] + k) && !numIndicesMap.ContainsKey(nums[idx] - k)){
            if(!numIndicesMap.ContainsKey(nums[idx])){
                numIndicesMap.Add(nums[idx], new HashSet<int>());
            }

            numIndicesMap[nums[idx]].Add(idx);
            DFS(nums, k, idx+1);
            numIndicesMap[nums[idx]].Remove(idx);

            if(numIndicesMap[nums[idx]].Count == 0){
                numIndicesMap.Remove(nums[idx]);
            }
        }
    }
}
}