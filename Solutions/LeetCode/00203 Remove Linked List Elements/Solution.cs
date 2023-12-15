using System;

namespace CompetitiveProgramming.LeetCode.RemoveLinkedListElements
{
    //Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
    // Example :
    // Input: head = [1,2,6,3,4,5,6], val = 6
    // Output: [1,2,3,4,5]

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
    // public class Solution {
    //     public ListNode RemoveElements(ListNode head, int val)
    //     {
    //         if (head != null) 
    //         {
    //             while(head != null && head.val == val)
    //             {
    //                 head = head.next;
    //             }
    //             for (ListNode num = head; num != null && num.next!= null;)
    //             {
    //                 if (num.next.val == val)
    //                     num.next = num.next.next;
                    
    //                 else num = num.next;
    //             }
                
    //         }
    //         return head;
    //     }
    // }
}
