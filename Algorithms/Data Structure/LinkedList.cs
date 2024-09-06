using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming.Algorithms
{
    public class LinkedList
    {   
        #region LC3217     
        private static ListNode RemoveSpecificsNumbersInLinkedList(int[] nums, ListNode head)
        {
            HashSet<int> valuesToRemove = CreateHashSetFromArray(nums);
            ListNode tempo = CreateTempoNode(head);
            RemoveNodes(tempo, valuesToRemove);
            return GetModifiedHead(tempo);
        }

        private static HashSet<int> CreateHashSetFromArray(int[] nums)
        {
            return new HashSet<int>(nums);
        }

        private static ListNode CreateTempoNode(ListNode head)
        {
            ListNode tempo = new ListNode(-1);
            tempo.next = head;
            return tempo;
        }

        private static void RemoveNodes(ListNode tempo, HashSet<int> valuesToRemove)
        {
            ListNode current = tempo;
            while (current.next != null)
            {
                if (valuesToRemove.Contains(current.next.val))
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
        }

        private static ListNode GetModifiedHead(ListNode tempo)
        {
            return tempo.next;
        }
        #endregion

        private static void PrintLinkedList(ListNode result)
        {
            while (result != null)
            {
                Console.Write(result.val + " -> ");
                result = result.next;
            }
            Console.WriteLine();
        }

        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode previous = null!;
            ListNode current = head;

            while(current != null)
            {
                ListNode nextTemp = current.next;
                current.next = previous;
                previous = current;
                current = nextTemp;
            }

            return previous;
        }

        private static ListNode AddLinkedListLast(ListNode head, int val)
        {
            ListNode newNode = new ListNode(val);
            if (head == null)
            {
                return newNode;
            }
            ListNode current = head;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = newNode;
            return head;
        }

        private static ListNode AddLinkedListFirst(ListNode head, int val)
        {
            ListNode newNode = new ListNode(val);
            newNode.next = head;
            return newNode;
        }

        private static ListNode RemoveLinkedListLast(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null!;
            }
            ListNode current = head;
            while (current.next.next != null)
            {
                current = current.next;
            }
            current.next = null!;
            return head;
        }

        private static ListNode RemoveLinkedListFirst(ListNode head)
        {
            if (head == null)
            {
                return null!;
            }
            return head.next;
        }

        private static ListNode RemoveAllOddsLinkedList(ListNode head)
        {
            ListNode tempo = new ListNode(-1);
            tempo.next = head;
            ListNode current = tempo;

            while (current.next != null)
            {
                if (current.next.val % 2 != 0) 
                {
                    current.next = current.next.next;
                } 
                else 
                {
                    current = current.next;
                }
            }
            return tempo.next;
        }

        private static ListNode RemoveAllEvensLinkedList(ListNode head) 
        {
            ListNode tempo = new ListNode(-1);
            tempo.next = head;
            ListNode current = tempo;

            while (current.next != null) 
            {
                if (current.next.val % 2 == 0) 
                {
                    current.next = current.next.next;
                } 
                else 
                {
                    current = current.next;
                }
            }
            return tempo.next;
        }

        private static double GetLinkedListMedian(ListNode head) 
        {
            if (head == null) return 0.0;

            List<int> values = new List<int>();
            ListNode current = head;
            while (current != null) 
            {
                values.Add(current.val);
                current = current.next;
            }

            values.Sort();
            int n = values.Count;

            if (n % 2 == 0) 
            {
                return (values[n / 2 - 1] + values[n / 2]) / 2.0;
            } 
            else 
            {
                return values[n / 2];
            }
        }

        private static double GetLinkedListMean(ListNode head)
        {
            if (head == null) return 0.0;

            int sum = 0, count = 0;
            ListNode current = head;
            while (current != null)
            {
                sum += current.val;
                count++;
                current = current.next;
            }

            return count == 0 ? 0.0 : (double)sum / count;
        }

        private static int GetLinkedListLength(ListNode head)
        {
            int length = 0;
            ListNode current = head;
            while (current != null)
            {
                length++;
                current = current.next;
            }
            return length;
        }

        private static bool ContainsNode(ListNode head, int target)
        {
            ListNode current = head;
            while (current != null)
            {
                if (current.val == target)
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }

        private static ListNode RemoveAtPositionLinkedList(ListNode head, int position)
        {
            if (position == 0)
            {
                return head.next;
            }
            ListNode current = head;
            for (int i = 0; i < position - 1 && current != null; i++)
            {
                current = current.next;
            }
            if (current == null || current.next == null)
            {
                return head;
            }
            current.next = current.next.next;
            return head;
        }

        private static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) 
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;

            while (slow != fast) 
            {
                if (fast == null || fast.next == null) 
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }

        private static ListNode GetMiddleNode(ListNode head) 
        {
            if (head == null) return null!;
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null) 
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }

        private static ListNode RemoveDuplicates(ListNode head) 
        {
            if (head == null) return null!;

            HashSet<int> seen = new HashSet<int>();
            ListNode current = head;
            seen.Add(current.val);

            while (current.next != null) 
            {
                if (seen.Contains(current.next.val)) 
                {
                    current.next = current.next.next;
                } 
                else
                {
                    seen.Add(current.next.val);
                    current = current.next;
                }
            }

            return head;
        }

        private static ListNode MergeTwoLinkedLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            ListNode current = l1;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = l2;
            return l1;
        }
    }
}