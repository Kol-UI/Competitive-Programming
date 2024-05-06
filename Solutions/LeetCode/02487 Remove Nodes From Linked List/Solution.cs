// Remove Nodes From Linked List


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveNodesFromLinkedList
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
        public ListNode RemoveNodes(ListNode head)
        {
            if(head.next == null)
                return head;

            var temp = RemoveNodes(head.next);
            if(head.val >= temp.val)
            {
                head.next = temp;
                return head;
            }

            return temp;  
        }
    }
}