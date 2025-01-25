// Make Lexicographically Smallest Array by Swapping Elements

namespace CompetitiveProgramming.LeetCode.MakeLexicographicallySmallestArraybySwappingElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] LexicographicallySmallestArray(int[] nums, int limit)
    {
        if(nums.Length == 1) return nums;    

        int[] sortNums = new int[nums.Length];
        sortNums = nums.ToArray();
        Array.Sort(sortNums);
        
        List<int> indStart = new List<int>();      

        Dictionary<int, int> numsGroup = new Dictionary<int, int>();
        
        numsGroup.Add(sortNums[0], 0);

        indStart.Add(0);     

        for(int i = 1; i < sortNums.Length; i++)
        {
            if(sortNums[i] - sortNums[i - 1] > limit) indStart.Add(i);  
            if(numsGroup.ContainsKey(sortNums[i]) == false)  numsGroup.Add(sortNums[i], indStart.Count - 1);        
        }    

        for(int i = 0; i < nums.Length; i++)
        {    
            nums[i] = sortNums[indStart[numsGroup[nums[i]]]];        
            indStart[numsGroup[nums[i]]]++;     
        }

        return nums;    
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Lexicographically Smallest Array by Swapping Elements");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}