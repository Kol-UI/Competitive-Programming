// Replace Non-Coprime Numbers in Array
namespace CompetitiveProgramming.LeetCode.ReplaceNonCoprimeNumbersinArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> ReplaceNonCoprimes(int[] nums)
    {
        Stack<long> stack = new();
        stack.Push(nums[0]);

        for(int i=1; i<nums.Length; i++)
        {
            stack.Push(nums[i]);
            
            while(stack.Count > 1)
            {
                var a = stack.Pop();
                var b = stack.Pop();
                long gcd = GetGCD(a, b);

                if(gcd == 1){
                    stack.Push(b);
                    stack.Push(a);
                    break;
                }

                var lcm = (a*b)/gcd;
                stack.Push(lcm);
            }
        }
        
        IList<int> res = new List<int>();

        while(stack.Count > 0)
        {
            res.Insert(0, (int)stack.Pop());
        }

        return res;
    }

    private long GetGCD(long a, long b)
    {
        if(a%b == 0) return b;

        return GetGCD(b, a%b);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Replace Non-Coprime Numbers in Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}