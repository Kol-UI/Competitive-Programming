// Ashton and String

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.HackerRank.AshtonandString
{
    class Result
    {

        /*
        * Complete the 'ashtonString' function below.
        *
        * The function is expected to return a CHARACTER.
        * The function accepts following parameters:
        *  1. STRING s
        *  2. INTEGER k
        */

        public static char AshtonString(string s, int k)
        {
            SortedSet<string> substrings = new();

            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i <= s.Length - len; i++)
                {
                    substrings.Add(s.Substring(i, len));
                }
            }

            int count = 0;
            foreach (string substring in substrings)
            {
                count += substring.Length;
                if (count >= k)
                {
                    return substring[k - count + substring.Length - 1];
                }
            }

            // Return null character if no result is found
            // return null can't be use because type is char so \0 instead
            return '\0'; 
        }

    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Result.AshtonString("dbac", 3), 99),
                ResultTester.CheckResult<int>(Result.AshtonString("abcdef", 4), 97),
                ResultTester.CheckResult<int>(Result.AshtonString("dbxyzac", 5), 98),
                ResultTester.CheckResult<int>(Result.AshtonString("aabbcc", 9), 98),
                ResultTester.CheckResult<int>(Result.AshtonString("hello", 7), 101),
            };
            return results;
        }
    }
}