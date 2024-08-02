// Double a Number Represented as a Linked List

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DoubleaNumberRepresentedasaLinkedList
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
    public class Solution
    {
        public ListNode Reverse(ListNode head)
        {
            ListNode prev = null!;
            ListNode curr = head;
            ListNode next = null!;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public ListNode DoubleIt(ListNode head)
        {
            ListNode aux1 = Reverse(head);
            ListNode aux2 = aux1;

            int carry = 0;

            while(aux1 != null)
            {
                aux1.val = aux1.val*2 + carry;
                carry = aux1.val/10;
                aux1.val = aux1.val%10;
                aux1 = aux1.next;
            }

            if(carry == 0)
                return Reverse(aux2);
            else
                return new ListNode(carry, Reverse(aux2));
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Double a Number Represented as a Linked List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}