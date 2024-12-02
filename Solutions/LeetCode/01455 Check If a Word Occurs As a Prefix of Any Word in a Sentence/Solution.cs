// Check If a Word Occurs As a Prefix of Any Word in a Sentence

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckIfaWordOccursAsaPrefixofAnyWordinaSentence
{
    public class Solution {
        public int IsPrefixOfWord(string sentence, string searchWord) {
            var wordId = -1;
            var sId = 0;
            var currWordId = 1;
            while (sId < sentence.Length)
            {
                var swId = 0;
                var found = true;
                while (sId < sentence.Length && !char.IsWhiteSpace(sentence[sId]))
                {
                    if (found && swId < searchWord.Length && sentence[sId] != searchWord[swId]) {
                        found = false;
                    }
                    swId++;
                    sId++;
                }
                if (found && swId >= searchWord.Length) {
                    wordId = currWordId;
                    break;
                }
                sId++;
                currWordId++;
            }
            return wordId;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Check If a Word Occurs As a Prefix of Any Word in a Sentence");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}