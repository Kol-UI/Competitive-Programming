// Sort List

/*
Given the head of a linked list, return the list after sorting it in ascending order.

 

Example 1:


Input: head = [4,2,1,3]
Output: [1,2,3,4]


Example 2:


Input: head = [-1,5,3,4,0]
Output: [-1,0,3,4,5]


Example 3:

Input: head = []
Output: []
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortList
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
        public ListNode SortList(ListNode head)
        {
            if(head == null)
                return null!;

            var sorted = ToSortedList(head);
            return BuildList(sorted);
        }
        
        private List<int> ToSortedList(ListNode head)
        {
            var res = new List<int>();
            while(head != null)
            {
                res.Add(head.val);
                head = head.next;
            }
            res.Sort();
            return res;
        }
        
        private ListNode BuildList(List<int> list)
        {
            var root = new ListNode(list[0]);
            var curr = root;
            for(int i = 1; i < list.Count; i++)
            {
                curr.next = new ListNode(list[i]);
                curr = curr.next;
            }
            return root;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort List");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}