using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.MinimumStepsRequired
{
    /*
        Given a string str consisting of only two characters 'a' and 'b'. You need to find the minimum steps required to make the string empty by removing consecutive a's and b's.

        Example 1:

        Input:
        str = "bbaaabb"
        Output:
        2
        Explanation:
        Operation 1: Removal of all a's modifies str to "bbbb".
        Operation 2: Removal of all remaining b's makes str
        empty.
        Therefore, the minimum number of operations required
        is 2.
        
        Example 2:

        Input:
        str = "aababaa"
        Output:
        3
        Explanation:
        Operation 1: Removal of b's modifies str to "aaabaa".
        Operation 2: Removal of b's modifies str = "aaaaa".
        Operation 3: Removal of all remaining a's makes str 
        empty.
        Therefore, the minimum number of operations required 
        is 3.
        
        Your Task:

        You need to complete the function minSteps() which takes a string str as the only input parameter and returns an integer, denoting the minimum steps required to make the string empty.
    */
    public class Solution
    {
        public static int minSteps(string str)
        {
            int Count = 0;
            for(int i = 1; i < str.Length; i++)
            {
                if(str[i-1] != str[i])
                {
                    Count++;
                }
            }
            if(Count%2!=0)
            {
                return (Count+1)/2 +1;
            }
            return Count/2 +1;
        }
    }

    public class Test
    {
        public static bool[] TestMinimumStepsRequired()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(MinimumStepsRequired.Solution.minSteps("bbaaabb"), 2),
                ResultTester.CheckResult<int>(MinimumStepsRequired.Solution.minSteps("aababaa"), 3)
            };
            return results;
        }
    }
}