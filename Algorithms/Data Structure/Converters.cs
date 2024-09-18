using CompetitiveProgramming.LeetCode;

namespace CompetitiveProgramming.Algorithms
{
    public class Converters
    {
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

        public static int BinaryToInt(string binary)
        {
            return Convert.ToInt32(binary, 2);
        }

        public static string IntToBinary(int number)
        {
            return Convert.ToString(number, 2);
        }

        public static string[] ConvertToStringArray(int[] nums)
        {
            return nums.Select(num => num.ToString()).ToArray();
        }
    }
}