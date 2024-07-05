// Find the Minimum and Maximum Number of Nodes Between Critical Points

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheMinimumandMaximumNumberofNodesBetweenCriticalPoints
{
    /**
    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int val=0, ListNode next=null) {
    *         this.val = val;
    *         this.next = next;
    *     }
    * }
    */

    public class Solution {
        public int[] NodesBetweenCriticalPoints(ListNode head) {

            ListNode previous = head;
            ListNode current = head.next;

            int startingPosition = -1;
            int previousPosition = -1;
            int position = 1;

            int[] result = new int[] {-1, -1};

            while (current != null && current.next != null) {
                if ((current.val > previous.val && current.val > current.next.val) || (current.val < previous.val && current.val < current.next.val)) {
                    if (startingPosition == -1)
                        startingPosition =  position;

                    if (previousPosition > -1) {
                        if (result[0] > position - previousPosition || result[0] == -1)
                            result[0] = position - previousPosition;
                        result[1] = position - startingPosition;
                    }
                    previousPosition = position;
                }
                
                previous = current;
                current = current.next;
                position++;
            }
            
            return result;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Minimum and Maximum Number of Nodes Between Critical Points");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}