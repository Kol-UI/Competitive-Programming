// Maximum Length

/*
Given the maximum occurrences of a, b, and c in a string. Your task is to make the string containing only a, b, and c such that no three consecutive characters are the same. If the resultant string equals to a+b+c, return the length (a+b+c) otherwise -1.

Example 1:
Input:
a = 3, b = 3, c = 3
Output: 
9
Explanation: 
No three consecutive character of
the string "abcabcabc" is same.

Example 2:
Input:
a = 11, b = 2, c = 2
Output: 
-1
Explanation: 
If we build a string of these character's,
the string will be"aabaacaabaacaaa", here
we can see that there will be three consecutive a. So
there is no solution exist.

Your Task:  
You don't need to read input or print anything. Your task is to complete the function solve( ) which takes integers a, b, and c as input parameters and returns the string length. If there is no possible answer return -1.
*/

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.MaximumLength
{
    public class Solution
    {
        public static int Solve(int a, int b, int c)
        {
            char prev = '0';
            int[] freq = {a, b, c};
            StringBuilder result = new StringBuilder("");

            while (true)
            {
                int ma = 0;
                char cur = ' ';

                for (int i = 0; i < 3; i++)
                {
                    if (prev != (char)(i + 'a') && ma < freq[i])
                    {
                        ma = freq[i];
                        cur = (char)(i + 'a');
                    }
                }

                if (ma == 0) 
                {
                    break;
                }

                result.Append(cur.ToString());
                freq[cur - 'a']--;
                
                if (ma >= 2 && (prev == '0' || ma > freq[prev - 'a'])) 
                {
                    result.Append(cur.ToString());
                    freq[cur - 'a']--;
                }
                prev = cur;
            }
            int n = result.Length;
            
            if(n != a + b + c)
            {
                return -1;
            }
            return n;
        }
    };

    public class Test
    {
        public static bool[] TestMaximumLength()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(MaximumLength.Solution.Solve(3, 3, 3), 9),
                ResultTester.CheckResult<int>(MaximumLength.Solution.Solve(11, 2, 2), -1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximum Length");
            ResultTester.CheckCurrentSolution(ProblemOrigin.GeeksForGeeks, ProblemCategory.MediumGFG, Test.TestMaximumLength());
        }
    }
}