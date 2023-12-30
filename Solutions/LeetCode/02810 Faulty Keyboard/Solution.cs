// Faulty Keyboard



using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FaultyKeyboard
{
    public class Solution 
    {
        public static string FinalString(string s)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'i')
                {
                    sb.Append(s[i]);
                    continue;
                }

                var sbInCharArr = sb.ToString().ToCharArray();
                Array.Reverse(sbInCharArr);

                sb.Clear().Append(new string(sbInCharArr));
            }

            return sb.ToString();
        }
    }
    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.FinalString("string"), "rtsng"),
                ResultTester.CheckResult<string>(Solution.FinalString("poiinter"), "ponter"),
            };
            return results;
        }
    }
}



