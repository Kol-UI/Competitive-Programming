// Insert Greatest Common Divisors in Linked List

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.InsertGreatestCommonDivisorsinLinkedList
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
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            if (head == null || head.next == null)
                return head!;

            ListNode current = head;

            while (current != null && current.next != null)
            {
                int gcdValue = CalculateGCD(current.val, current.next.val);
                InsertNode(current, gcdValue);
                current = current.next.next;
            }

            return head;
        }

        private static int CalculateGCD(int a, int b)
        {
            while (b != 0)
            {
                int tempo = b;
                b = a % b;
                a = tempo;
            }
            return a;
        }

        private static void InsertNode(ListNode current, int value)
        {
            ListNode newNode = new ListNode(value);
            newNode.next = current.next;
            current.next = newNode;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new Solution();

            int[] input1 = { 18, 6, 10, 3 };
            ListNode head1 = ConvertArrayToLinkedList(input1);
            ListNode result1 = solution.InsertGreatestCommonDivisors(head1);
            int[] expectedOutput1 = { 18, 6, 6, 2, 10, 1, 3 };
            int[] actualOutput1 = ConvertLinkedListToArray(result1);
            PrintIntArray(expectedOutput1); PrintIntArray(actualOutput1);


            int[] input2 = { 7 };
            ListNode head2 = ConvertArrayToLinkedList(input2);
            ListNode result2 = solution.InsertGreatestCommonDivisors(head2);
            int[] expectedOutput2 = { 7 };
            int[] actualOutput2 = ConvertLinkedListToArray(result2);
            PrintIntArray(expectedOutput2); PrintIntArray(actualOutput2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(expectedOutput1, actualOutput1),
                ResultTester.CheckResult<int[]>(expectedOutput2, actualOutput2),
            };
            return results;
        }

        public static ListNode ConvertArrayToLinkedList(int[] values)
        {
            if (values.Length == 0) return null!;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;
            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }

        public static int[] ConvertLinkedListToArray(ListNode head)
        {
            var list = new List<int>();
            ListNode current = head;

            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }

            return list.ToArray();
        }

        public static void PrintIntArray(int[] array)
        {
            Console.WriteLine(String.Join(", ", array));
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Insert Greatest Common Divisors in Linked List");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}