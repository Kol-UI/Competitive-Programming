// Maximal Score After Applying K Operations

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximalScoreAfterApplyingKOperations
{
    public class Solution {
        public long MaxKelements(int[] nums, int k) {
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (int num in nums) {
                maxHeap.Enqueue(num, num); 
            }
            
            long score = 0;

            for (int i = 0; i < k; i++) {
                int maxElement = maxHeap.Dequeue();

                score += maxElement;

                int newElement = (int)Math.Ceiling(maxElement / 3.0);

                maxHeap.Enqueue(newElement, newElement);
            }
            
            return score;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximal Score After Applying K Operations");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}