// Kth Largest Element in a Stream

/*
Design a class to find the kth largest element in a stream. Note that it is the kth largest element in the sorted order, not the kth distinct element.

Implement KthLargest class:

KthLargest(int k, int[] nums) Initializes the object with the integer k and the stream of integers nums.
int add(int val) Appends the integer val to the stream and returns the element representing the kth largest element in the stream.
 

Example 1:

Input
["KthLargest", "add", "add", "add", "add", "add"]
[[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
Output
[null, 4, 5, 5, 8, 8]

Explanation
KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
kthLargest.add(3);   // return 4
kthLargest.add(5);   // return 5
kthLargest.add(10);  // return 5
kthLargest.add(9);   // return 8
kthLargest.add(4);   // return 8
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.KthLargestElementinaStream
{
    public class KthLargest
    {
        PriorityQueue<int, int> arr = new PriorityQueue<int, int>();
        int _k = 0;

        public KthLargest(int k, int[] nums)
        {
            for (int i = 0; i < nums.Length; i++) arr.Enqueue(nums[i], nums[i]);
            
            while (k < arr.Count) arr.Dequeue();
            
            _k = k;
        }
        
        public int Add(int val)
        {
            if(arr.Count<_k) arr.Enqueue(val,val);
            else arr.EnqueueDequeue(val, val);
            return arr.Peek();
        }
    }

    /**
    * Your KthLargest object will be instantiated and called as such:
    * KthLargest obj = new KthLargest(k, nums);
    * int param_1 = obj.Add(val);
    */

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("703");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}