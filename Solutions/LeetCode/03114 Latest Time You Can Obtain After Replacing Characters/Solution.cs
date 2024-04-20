// Latest Time You Can Obtain After Replacing Characters

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LatestTimeYouCanObtainAfterReplacingCharacters
{
    public class Solution
    {
        public static string FindLatestTime(string s)
        {
            char[] values = s.ToCharArray();
            if(values[0] == '?')
            {
                if(values[1] == '?' || values[1] == '0' || values[1] == '1')
                    values[0] = '1';
                else
                    values[0] = '0';
            }
            if(values[1] == '?')
            {
                if(values[0] == '0')
                    values[1] = '9';
                else
                    values[1] = '1';
            }
            if(values[3] == '?')
                values[3] = '5';
            if(values[4] == '?')
                values[4] = '9';

            return new string(values);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.FindLatestTime("1?:?4"), "11:54"),
                ResultTester.CheckResult<string>(Solution.FindLatestTime("0?:5?"), "09:59"),
            };
            return results;
        }
    }
}