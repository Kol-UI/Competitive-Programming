// Find Median from Data Stream


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindMedianfromDataStream
{
    public class MedianFinder
    {
        PriorityQueue<int, int> leftQueue;
        PriorityQueue<int, int> rightQueue;
        public MedianFinder()
        {
            leftQueue = new PriorityQueue<int, int>();
            rightQueue = new PriorityQueue<int, int>();
        }
        
        public void AddNum(int num)
        {
            leftQueue.Enqueue(num, -num);
            int val = 0;
            
            if(leftQueue.Count > 0 && rightQueue.Count > 0 && leftQueue.Peek() > rightQueue.Peek())
            {
                val = leftQueue.Dequeue();
                rightQueue.Enqueue(val, val);
            }
            
            if(leftQueue.Count > rightQueue.Count + 1)
            {
                val = leftQueue.Dequeue();
                rightQueue.Enqueue(val, val);
            }
            
            else if(rightQueue.Count > leftQueue.Count + 1)
            {
                val = rightQueue.Dequeue();
                leftQueue.Enqueue(val, -val);
            }
        }
        
        public double FindMedian()
        {
            if(leftQueue.Count > rightQueue.Count)
            {
                return leftQueue.Peek();
            }
            
            else if (rightQueue.Count > leftQueue.Count)
            {
                return rightQueue.Peek();
            }

            return (leftQueue.Peek() + rightQueue.Peek()) / 2.0;
        }
    }

    /**
    * Your MedianFinder object will be instantiated and called as such:
    * MedianFinder obj = new MedianFinder();
    * obj.AddNum(num);
    * double param_2 = obj.FindMedian();
    */

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Median from Data Stream");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}