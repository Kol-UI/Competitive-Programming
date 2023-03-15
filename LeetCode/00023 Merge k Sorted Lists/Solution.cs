using System;
namespace CompetitiveProgramming.LeetCode.MergekSortedLists
{
    // You are given an array of k linked-lists lists, each linked-list is sorted in ascending order.
    // Merge all the linked-lists into one sorted linked-list and return it.

    // Example 1:
    // Input: lists = [[1,4,5],[1,3,4],[2,6]]
    // Output: [1,1,2,3,4,4,5,6]
    // Explanation: The linked-lists are:
    // [
    // 1->4->5,
    // 1->3->4,
    // 2->6
    // ]
    // merging them into one sorted list:
    // 1->1->2->3->4->4->5->6

    // Example 2:
    // Input: lists = []
    // Output: []

    // Example 3:
    // Input: lists = [[]]
    // Output: []

    /*
    public class Solution 
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            
            if(lists == null || lists.Length ==0)
            {
                return null;
            }

            return MergeSort(lists, 0, lists.Length -1);
        }

        public ListNode MergeSort(ListNode[] lists, int startIdx, int endIdx)
        {
            if(startIdx == endIdx)
            {
                return lists[startIdx];
            }

            int midIdx = (startIdx+endIdx)/2;

            ListNode left = MergeSort(lists, startIdx, midIdx);
            ListNode right = MergeSort(lists, midIdx+1, endIdx);
            return Merge(left, right);
        }

        public ListNode Merge(ListNode left, ListNode right)
        {
            ListNode dummy = new ListNode(-1);
            ListNode tail = dummy;

            while(left !=null && right !=null)
            {

                if(left.val <right.val)
                {
                    tail.next = left;
                    left = left.next;
                }
                else
                {
                    tail.next = right;
                    right = right.next;
                }
                tail = tail.next;

            }

            if(left !=null)
            {
                tail.next = left;
                left = left.next;
                tail = tail.next;
            }

            if(right !=null)
            {
                tail.next = right;
                right = right.next;
                tail = tail.next;
            }

            return dummy.next;

        }
    }
    */
}