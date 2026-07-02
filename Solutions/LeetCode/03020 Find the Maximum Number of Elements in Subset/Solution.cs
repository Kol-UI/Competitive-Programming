// Find the Maximum Number of Elements in Subset
namespace CompetitiveProgramming.LeetCode.FindtheMaximumNumberofElementsinSubset;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumLength(int[] nums)
    {
       Dictionary<long,int> dict = new Dictionary<long,int>();
       foreach(int i in nums)
       {
           if(dict.ContainsKey(i))
               dict[i] = dict[i] + 1;
            else
                dict[i] = 1;    
       }

       int maxi = dict.ContainsKey(1) ? (dict[1]%2 ==0 ? dict[1]-1 : dict[1]  ) : 1;

       for(int i=0; i< nums.Length; i++)
       {
           int count =0;
           long val = nums[i];
           while (val <= 1e9 && dict.ContainsKey(val) && dict[val] >= 2 && val != 1) 
           {
                count += 2;
                val *= val;
            }
            if (dict.ContainsKey(val)) 
            {
                count++;
            }
            else
            {
                count--;
            }
            maxi = Math.Max(count, maxi);
       }
       return maxi;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaximumLength([5,4,1,2,2]), 3),
            ResultTester.CheckResult<int>(solution.MaximumLength([1,3,2,4]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the Maximum Number of Elements in Subset");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}