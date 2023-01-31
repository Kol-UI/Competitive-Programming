using System;
namespace CompetitiveProgramming.LeetCode.RestoreIPAddresses
{
	public class Solution
	{
        //A valid IP address consists of exactly four integers separated by single dots.Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.

        //For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
        //Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s. You are not allowed to reorder or remove any digits in s.You may return the valid IP addresses in any order.

        //Example 1:

        //Input: s = "25525511135"
        //Output: ["255.255.11.135","255.255.111.35"]

        //Example 2:

        //Input: s = "0000"
        //Output: ["0.0.0.0"]

        //Example 3:

        //Input: s = "101023"
        //Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]


        public static IList<string> RestoreIpAddresses(string s)
        {
            IList<string> ans = new List<string>();

            if (s.Length > 12)
                return ans;

            Backtrack(s, 0, new List<string>(), ans);
            return ans;
        }

        private static void Backtrack(string s, int st, IList<string> li, IList<string> ans)
        {
            if (st == s.Length && li.Count == 4)
            {
                string ip = string.Join(".", li.ToArray());
                ans.Add(ip);
                return;
            }

            for (int len = 1; len <= s.Length - st; len++)
            {
                string str = s.Substring(st, len);

                if (IsValid(str))
                {
                    li.Add(str);
                    Backtrack(s, st + len, li, ans);
                    li.RemoveAt(li.Count - 1);
                }
            }
        }

        private static bool IsValid(string str)
        {
            if (str.Length > 3)
                return false;

            int num = int.Parse(str);

            if (num < 0 || num > 255 || str.Length != num.ToString().Length)
                return false;

            return true;
        }

    }
}

