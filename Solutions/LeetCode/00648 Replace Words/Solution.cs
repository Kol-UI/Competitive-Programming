// Replace Words

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReplaceWords
{
    public class Solution
    {
        public static string ReplaceWords(IList<string> dictionary, string sentence) {
            return string.Join(" ", 
                sentence.Split()
                    .Select(w => dictionary
                        .Where(d => d.Length <= w.Length && w[..d.Length].Equals(d))
                        .MinBy(x => x.Length) ?? w)
                );
        }
    }
}