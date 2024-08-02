// Maximum Length of a Concatenated String with Unique Characters


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximumLengthofaConcatenatedStringwithUniqueCharacters
{
    public class Solution
    {
        public static int MaxLength(IList<string> arr)
        {
            return DFS(ref arr,0,"");
        }

        public static int DFS(ref IList<string> arr, int idx, string cursequence) 
        {
            int maxlen = 0;
            for(int i = idx; i<arr.Count; i++)
            {
                int count = isuniqueCount(cursequence+arr[i]);
                if (count > 0)
                {
                    maxlen = Math.Max(count, maxlen);
                    maxlen = Math.Max(maxlen, DFS(ref arr,i+1,cursequence+arr[i]));
                }
            }
            return maxlen;
        }

        public static int isuniqueCount(string s)
        {
            bool[] ischarpresent = new bool[26];
            int len = 0;

            foreach(char c in s)
            {
                int charindex = (int)c - (int)'a';
                if(ischarpresent[charindex] == true)
                {
                    return 0;
                } 
                ischarpresent[charindex] = true;
                len++;
            }
            return len;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxLength(new string[]{"un","iq","ue"}), 4),
                ResultTester.CheckResult<int>(Solution.MaxLength(new string[]{"abcdefghijklmnopqrstuvwxyz"}), 26),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("1239");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}