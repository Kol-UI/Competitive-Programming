// Search Suggestions System

/*
You are given an array of strings products and a string searchWord.

Design a system that suggests at most three product names from products after each character of searchWord is typed. Suggested products should have common prefix with searchWord. If there are more than three products with a common prefix return the three lexicographically minimums products.

Return a list of lists of the suggested products after each character of searchWord is typed.

 

Example 1:

Input: products = ["mobile","mouse","moneypot","monitor","mousepad"], searchWord = "mouse"
Output: [["mobile","moneypot","monitor"],["mobile","moneypot","monitor"],["mouse","mousepad"],["mouse","mousepad"],["mouse","mousepad"]]
Explanation: products sorted lexicographically = ["mobile","moneypot","monitor","mouse","mousepad"].
After typing m and mo all products match and we show user ["mobile","moneypot","monitor"].
After typing mou, mous and mouse the system suggests ["mouse","mousepad"].

Example 2:

Input: products = ["havana"], searchWord = "havana"
Output: [["havana"],["havana"],["havana"],["havana"],["havana"],["havana"]]
Explanation: The only word "havana" will be always suggested while typing the search word.
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SearchSuggestionsSystem
{
    public class Solution
    {
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            var result = new List<IList<string>>();
            for(int i = 1; i <= searchWord.Length; i++)
            {
                var curSearchWord=searchWord.Substring(0,i);
                result.Add
                (
                    products
                    .Where(p => (p.Length > i ? p.Substring(0, i) : p) == curSearchWord)
                    .OrderBy(p => p)
                    .Take(3)
                    .ToList()
                );
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestSearchSuggestionsSystem()
        {
            string[] products1 = {"mobile","mouse","moneypot","monitor","mousepad"}; string searchWord1 = "mouse";
            string[] products2 = {"havana"}; string searchWord2 = "havana";
            IList<IList<string>> result1 = LeetCode.SearchSuggestionsSystem.Solution.SuggestedProducts(products1, searchWord1);
            IList<IList<string>> result2 = LeetCode.SearchSuggestionsSystem.Solution.SuggestedProducts(products2, searchWord2);
            IList<IList<string>> input1 = new List<IList<string>>
            {
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mobile", "moneypot", "monitor" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" },
                new List<string> { "mouse", "mousepad" }
            };
            IList<IList<string>> input2 = new List<IList<string>>
            {
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" },
                new List<string> { "havana" }
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<IList<string>>>(result1, input1),
                ResultTester.CheckResult<IList<IList<string>>>(result2, input2),
            };
            return results;
        }
    }
}