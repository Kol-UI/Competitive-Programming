// Remove Zero Sum Consecutive Nodes from Linked List


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.RemoveZeroSumConsecutiveNodesfromLinkedList
{
    public class Solution
    {
        public static ListNode RemoveZeroSumSublists(ListNode head)
        {
            var curr = head;
            IList<int> arr = new List<int>();
            var result = new ListNode();
            
            while(curr != null)
            {
                arr.Add(curr.val);
                curr = curr.next;
            }

            int i = 0;
            curr = result;

            while(i < arr.Count)
            {
                int j = i;
                int sum = arr[j++];

                while(j<arr.Count && sum != 0)
                {
                    sum += arr[j++];
                }

                if(sum == 0)
                {
                    i = j;
                }
                else
                {
                    curr.next = new ListNode(arr[i]);
                    curr = curr.next;
                    i++;
                }
            }
            
            return result.next;
        }
    }
}