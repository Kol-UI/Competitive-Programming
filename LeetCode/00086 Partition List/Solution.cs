// Partition List



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

namespace CompetitiveProgramming.LeetCode.PartitionList;
public class Solution
{
    public ListNode Partition(ListNode head, int x)
    {
        ListNode lessHead = null!;
        ListNode moreHead = null!;
        
        ref var lessTail = ref lessHead;
        ref var moreTail = ref moreHead;

        for (var node = head; node != null; node = node.next)
        {
            if (node.val < x)
            {
                lessTail = node;
                lessTail = ref node.next!;
            }
            else
            {
                moreTail = node;
                moreTail = ref node.next!;
            }
        }

        lessTail = moreHead;
        moreTail = null;

        return lessHead;
    }
}