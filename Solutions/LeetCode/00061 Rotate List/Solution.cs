// Rotate List

/*
Given the head of a linked list, rotate the list to the right by k places.

 

Example 1:


Input: head = [1,2,3,4,5], k = 2
Output: [4,5,1,2,3]


Example 2:


Input: head = [0,1,2], k = 4
Output: [2,0,1]
*/

namespace CompetitiveProgramming.LeetCode.RotateList
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
        public static ListNode RotateRight(ListNode head, int k)
        {
            var queue = new Queue<ListNode>();
            if(k == 0) return head;
            var first = head;
            while(head != null)
            {
                if(head.next == null && queue.Count == k)
                {
                    head.next = first;
                    queue.Dequeue().next = null!;
                    first = queue.Count > 0 ? queue.Peek() : head;
                    break;
                }
                if(queue.Count == k) queue.Dequeue();

                queue.Enqueue(head);

                if(head.next == null && queue.Count != k)
                {
                    k = k % queue.Count;
                    if(k == 0) break;
                    queue.Clear();
                } 
                head = head.next ?? first;
            }
            return first;
        }
    }
}