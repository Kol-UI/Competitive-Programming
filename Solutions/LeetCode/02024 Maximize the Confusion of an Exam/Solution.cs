// Maximize the Confusion of an Exam

/*
A teacher is writing a test with n true/false questions, with 'T' denoting true and 'F' denoting false. He wants to confuse the students by maximizing the number of consecutive questions with the same answer (multiple trues or multiple falses in a row).

You are given a string answerKey, where answerKey[i] is the original answer to the ith question. In addition, you are given an integer k, the maximum number of times you may perform the following operation:

Change the answer key for any question to 'T' or 'F' (i.e., set answerKey[i] to 'T' or 'F').
Return the maximum number of consecutive 'T's or 'F's in the answer key after performing the operation at most k times.

 

Example 1:

Input: answerKey = "TTFF", k = 2
Output: 4
Explanation: We can replace both the 'F's with 'T's to make answerKey = "TTTT".
There are four consecutive 'T's.

Example 2:

Input: answerKey = "TFFT", k = 1
Output: 3
Explanation: We can replace the first 'T' with an 'F' to make answerKey = "FFFT".
Alternatively, we can replace the second 'T' with an 'F' to make answerKey = "TFFF".
In both cases, there are three consecutive 'F's.

Example 3:

Input: answerKey = "TTFTTFTT", k = 1
Output: 5
Explanation: We can replace the first 'F' to make answerKey = "TTTTTFTT"
Alternatively, we can replace the second 'F' to make answerKey = "TTFTTTTT". 
In both cases, there are five consecutive 'T's.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MaximizetheConfusionofanExam
{
    public class Solution
    {
        public static int MaxConsecutiveAnswers(string answerKey, int k)
        {
            int longestConsecutiveCount = 0;
            int left = 0;
            int maxChanges = k;
            int tCount = 0;
            int fCount = 0;
            
            for (int right = 0; right < answerKey.Length; right++)
            {
                char currentAnswer = answerKey[right];
                
                if (currentAnswer == 'T')
                {
                    tCount++;
                }
                else
                {
                    fCount++;
                }
                
                while (Math.Min(tCount, fCount) > maxChanges)
                {
                    char leftAnswer = answerKey[left];
                    
                    if (leftAnswer == 'T')
                    {
                        tCount--;
                    }
                    else
                    {
                        fCount--;
                    }
                    
                    left++;
                }
                
                longestConsecutiveCount = Math.Max(longestConsecutiveCount, right - left + 1);
            }
            
            return longestConsecutiveCount;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxConsecutiveAnswers("TTFF", 2), 4),
                ResultTester.CheckResult<int>(Solution.MaxConsecutiveAnswers("TFFT", 1), 3),
                ResultTester.CheckResult<int>(Solution.MaxConsecutiveAnswers("TTFTTFTT", 1), 5),
            };
            return results;
        }
    }
}