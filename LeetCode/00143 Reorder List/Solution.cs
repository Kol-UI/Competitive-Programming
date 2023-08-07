// Reorder List


using System;
namespace CompetitiveProgramming.LeetCode.ReorderList
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
        public void ReorderList(ListNode head)
        {
            var tempNode1 = head;
            var tempNode2 = head;
            var stack = new Stack<int>();
            var queue = new Queue<int>();

            while (tempNode1 != null)
            {
                stack.Push(tempNode1.val);
                queue.Enqueue(tempNode1.val);

                tempNode1 = tempNode1.next;
            }

            var counter = 1;

            while (tempNode2 != null)
            {
                if (counter % 2 == 0) tempNode2.val = stack.Pop();
                
                else tempNode2.val = queue.Dequeue();
                
                tempNode2 = tempNode2.next;
                counter++;
            }
        }
    }

}