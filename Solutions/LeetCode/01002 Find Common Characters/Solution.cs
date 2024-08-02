// Find Common Characters


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindCommonCharacters
{
    public class Solution
    {
        public IList<string> CommonChars(string[] words)
        {
            var result = new List<string>();
            var firstWord = words[0];
            foreach(char c in firstWord)
            {
                var match = false;
                for(int i = 1; i < words.Length; i++)
                {
                    match = words[i].IndexOf(c) != -1;
                    if(!match) break;
                }
                if(match) 
                {
                    result.Add(c.ToString());
                    for(int i = 1; i < words.Length; i++)
                    {
                        var index = words[i].IndexOf(c);
                        if(index > -1) words[i] = words[i].Remove(index,1);
                    }
                        
                }
            }
            return result;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find Common Characters");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}