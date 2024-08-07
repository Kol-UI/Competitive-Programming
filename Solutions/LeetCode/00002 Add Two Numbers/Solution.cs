﻿using System;
using System.Collections.Generic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.AddTwoNumbers
{
    public class Solution
    {
        //You are given two non-empty linked lists representing two non-negative integers.
        //The digits are stored in reverse order, and each of their nodes contains a single digit.
        //Add the two numbers and return the sum as a linked list.

        //You may assume the two numbers do not contain any leading zero, except the number 0 itself.

        /* public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode? next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int x = 0;
            var listNode = new ListNode();
            var current = listNode;

            while (l1 != null || l2 != null || x == 1)
            {
                if (l1 == null)
                {
                    l1 = new ListNode(0);
                }
                if (l2 == null)
                {
                    l2 = new ListNode(0);
                }
                if (l1.val + l2.val + x >= 10)
                {
                    current.next = new ListNode((l1.val + l2.val + x) % 10);
                    x = 1;
                }
                else
                {
                    current.next = new ListNode(l1.val + l2.val + x);
                    x = 0;
                }
                current = current.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            return listNode.next;
        } */
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Add Two Numbers");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}