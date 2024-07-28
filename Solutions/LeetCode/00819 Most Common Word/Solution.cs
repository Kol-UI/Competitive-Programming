// Most Common Word

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MostCommonWord
{
    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            string[] words = paragraph.ToString().ToLower().Split(new char[] { ' ', ',', '.', '!', '?', ':', ';', '\'', '\"' });
            Dictionary<string,int> dic = new Dictionary<string,int>();  

            foreach (string word in words)
            {
                if (banned.Contains(word))
                    continue;
                if (word == "")
                    continue;
                if (dic.ContainsKey(word))
                    dic[word]++;
                else
                    dic.Add(word, 1);
            }

            return  dic.First(x => x.Value == dic.Values.Max()).Key;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Most Common Word");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}