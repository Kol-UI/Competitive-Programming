// Count Complete Subarrays in an Array
namespace CompetitiveProgramming.LeetCode.CountCompleteSubarraysinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var dic = new Dictionary<int, int>();
        var index0 = 0;
        var index1 = 0;
        dic.Add(nums[index0], 1);
        var rs = 0;
        while (index0 <= nums.Length - set.Count)
        {
            if (dic.Count == set.Count)
            {
                rs += nums.Length - index1;
                RemoveFromDic(nums[index0], dic);
                if (index0 == index1)
                {
                    index1++;
                    if (index1 >= nums.Length) break;
                    AddToDic(nums[index1], dic);
                }
                index0++;
            }
            else
            {
                index1++;
                if (index1 >= nums.Length) break;
                AddToDic(nums[index1], dic);
            }
        }
        return rs;
    }
    private void AddToDic(int key, Dictionary<int, int> dic)
    {
        if (!dic.ContainsKey(key))
        {
            dic.Add(key, 1);
        }
        else
        {
            dic[key]++;
        }
    }
    private void RemoveFromDic(int key, Dictionary<int, int> dic)
    {
        if (dic[key] == 1)
        {
            dic.Remove(key);
        }
        else
        {
            dic[key]--;
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Complete Subarrays in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}