// Best Poker Hand

/*
You are given an integer array ranks and a character array suits. You have 5 cards where the ith card has a rank of ranks[i] and a suit of suits[i].

The following are the types of poker hands you can make from best to worst:

"Flush": Five cards of the same suit.
"Three of a Kind": Three cards of the same rank.
"Pair": Two cards of the same rank.
"High Card": Any single card.
Return a string representing the best type of poker hand you can make with the given cards.

Note that the return values are case-sensitive.

 

Example 1:

Input: ranks = [13,2,3,1,9], suits = ["a","a","a","a","a"]
Output: "Flush"
Explanation: The hand with all the cards consists of 5 cards with the same suit, so we have a "Flush".

Example 2:

Input: ranks = [4,4,2,4,4], suits = ["d","a","a","b","c"]
Output: "Three of a Kind"
Explanation: The hand with the first, second, and fourth card consists of 3 cards with the same rank, so we have a "Three of a Kind".
Note that we could also make a "Pair" hand but "Three of a Kind" is a better hand.
Also note that other cards could be used to make the "Three of a Kind" hand.

Example 3:

Input: ranks = [10,10,2,12,9], suits = ["a","b","c","a","d"]
Output: "Pair"
Explanation: The hand with the first and second card consists of 2 cards with the same rank, so we have a "Pair".
Note that we cannot make a "Flush" or a "Three of a Kind".
 

Constraints:

ranks.length == suits.length == 5
1 <= ranks[i] <= 13
'a' <= suits[i] <= 'd'
No two cards have the same rank and suit.
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BestPokerHand
{
    public class Solution 
    {
        public static string BestHand(int[] ranks, char[] suits)
        {
            int[] suitMap = new int[4];
            int[] rankMap = new int[14];
            int maxRankCount = 0;
            int maxSuitCount = 0;
            
            for (var i = 0; i < ranks.Length; i++)
            {
                suitMap[suits[i] - 'a']++;
                maxSuitCount = Math.Max(suitMap[suits[i] - 'a'], maxSuitCount);
                rankMap[ranks[i]]++;
                maxRankCount = Math.Max(rankMap[ranks[i]], maxRankCount);
            }

            if (maxSuitCount == suits.Length)
            {
                return "Flush";
            }
            if (maxRankCount >= 3)
            {
                return "Three of a Kind";
            }
            if (maxRankCount == 2)
            {
                return "Pair";
            }
            return "High Card";        
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[] ranks1 = {13,2,3,1,9};
            char[] suits1 = {'a','a','a','a','a'};
            string Case1_2347 = Solution.BestHand(ranks1, suits1);

            // Case 2
            int[] ranks2 = {4,4,2,4,4};
            char[] suits2 = {'d','a','a','b','c'};
            string Case2_2347 = Solution.BestHand(ranks2, suits2);

            // Case 3
            int[] ranks3 = {10,10,2,12,9};
            char[] suits3 = {'a','b','c','a','d'};
            string Case3_2347 = Solution.BestHand(ranks3, suits3);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Case1_2347, "Flush"),
                ResultTester.CheckResult<string>(Case2_2347, "Three of a Kind"),
                ResultTester.CheckResult<string>(Case3_2347, "Pair")
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Best Poker Hand");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}