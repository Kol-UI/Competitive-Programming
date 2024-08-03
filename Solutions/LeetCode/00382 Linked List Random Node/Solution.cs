using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LinkedListRandomNode
{
    // Given a singly linked list, return a random node's value from the linked list. Each node must have the same probability of being chosen.
    // Implement the Solution class:
    // Solution(ListNode head) Initializes the object with the head of the singly-linked list head.
    // int getRandom() Chooses a node randomly from the list and returns its value. All the nodes of the list should be equally likely to be chosen.
    // Example:
    // Input
    // ["Solution", "getRandom", "getRandom", "getRandom", "getRandom", "getRandom"]
    // [[[1, 2, 3]], [], [], [], [], []]
    // Output
    // [null, 1, 3, 2, 2, 3]

    // Explanation
    // Solution solution = new Solution([1, 2, 3]);
    // solution.getRandom(); // return 1
    // solution.getRandom(); // return 3
    // solution.getRandom(); // return 2
    // solution.getRandom(); // return 2
    // solution.getRandom(); // return 3
    // // getRandom() should return either 1, 2, or 3 randomly. Each element should have equal probability of returning.

    // Solution obj = new Solution(head);
    // int param_1 = obj.GetRandom();
    public class Solution
    {
        private List<int> values;
        private Random random;
        public Solution(ListNode head)
        {
            values = new List<int>();
            random = new Random(0);
            
            while(head != null){
                values.Add(head.val);
                head = head.next;
            }
        }
        
        public int GetRandom()
        {
            return values.ElementAt(random.Next(values.Count));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Linked List Random Node");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}