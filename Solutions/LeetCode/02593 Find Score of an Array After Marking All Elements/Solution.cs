// Find Score of an Array After Marking All Elements

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindScoreofanArrayAfterMarkingAllElements
{
    public class Solution
    {
        public long FindScore(int[] nums)
        {
            var minHeap = new PriorityQueue<int,(int,int)>();
            long score = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                minHeap.Enqueue(i,(nums[i],i));
            }

            while(minHeap.Count > 0)
            {
                var index = minHeap.Dequeue();
                if(nums[index] != -1)
                {
                    score += nums[index];
                    nums[index] = -1;

                    if(index - 1 >= 0)
                        nums[index-1] = -1;
                    if(index + 1 < nums.Length)
                        nums[index+1] = -1;
                }
            }
            return score;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Score of an Array After Marking All Elements");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}