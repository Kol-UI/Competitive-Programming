using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NamingaCompany
{
	public class Solution
    {
        // You are given an array of strings ideas that represents a list of names to be used in the process of naming a company. The process of naming a company is as follows:

        // Choose 2 distinct names from ideas, call them ideaA and ideaB.
        // Swap the first letters of ideaA and ideaB with each other.
        // If both of the new names are not found in the original ideas, then the name ideaA ideaB (the concatenation of ideaA and ideaB, separated by a space) is a valid company name.
        // Otherwise, it is not a valid name.
        // Return the number of distinct valid names for the company.

        // Example 1:

        // Input: ideas = ["coffee","donuts","time","toffee"]
        // Output: 6
        // Explanation: The following selections are valid:
        // - ("coffee", "donuts"): The company name created is "doffee conuts".
        // - ("donuts", "coffee"): The company name created is "conuts doffee".
        // - ("donuts", "time"): The company name created is "tonuts dime".
        // - ("donuts", "toffee"): The company name created is "tonuts doffee".
        // - ("time", "donuts"): The company name created is "dime tonuts".
        // - ("toffee", "donuts"): The company name created is "doffee tonuts".
        // Therefore, there are a total of 6 distinct company names.

        // The following are some examples of invalid selections:
        // - ("coffee", "time"): The name "toffee" formed after swapping already exists in the original array.
        // - ("time", "toffee"): Both names are still the same after swapping and exist in the original array.
        // - ("coffee", "toffee"): Both names formed after swapping already exist in the original array.
        
        // Example 2:

        // Input: ideas = ["lack","back"]
        // Output: 0
        // Explanation: There are no valid selections. Therefore, 0 is returned.

        public static long DistinctNames(string[] ideas) 
        {
            HashSet<string>[] initialGroup = new HashSet<string>[26];
            for (int i = 0; i < 26; ++i)
            {
                initialGroup[i] = new HashSet<String>();
            }
            foreach (string idea in ideas) 
            {
                initialGroup[idea[0] - 'a'].Add(idea.Substring(1));
            }
            
            long answer = 0;
            for (int i = 0; i < 25; ++i) 
            {
                for (int j = i + 1; j < 26; ++j) 
                {
                    long numOfMutual = 0;
                    foreach (string ideaA in initialGroup[i]) 
                    {
                        if (initialGroup[j].Contains(ideaA)) 
                        {
                            numOfMutual++;
                        }
                    }
                    answer += 2 * (initialGroup[i].Count - numOfMutual) * (initialGroup[j].Count - numOfMutual);
                }
            }
            
            return answer;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            string[] arrayCase1_2306 = { "coffee", "donuts", "time", "toffee"};
            long Case1_2306_Result = Solution.DistinctNames(arrayCase1_2306);

            // Case 2
            string[] arrayCase2_2306 = { "lack", "back"};
            long Case2_2306_Result = Solution.DistinctNames(arrayCase2_2306);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Case1_2306_Result, 6),
                ResultTester.CheckResult<long>(Case2_2306_Result, 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Naming a Company");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}