// Find the K-th Character in String Game I
namespace CompetitiveProgramming.LeetCode.FindtheKthCharacterinStringGameI;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public char KthCharacter(int k)
    {
        string word = "ab";
        StringBuilder generated = new StringBuilder("b");

        while(word.Length < k)
        {
            int x = generated.Length;
            for(int i = 0; i < x; i++)
            {
                if(generated[i] != 'z')
                {
                    generated.Append((char)((int)generated[i] + 1));
                }
                else
                {
                    generated.Append('a');
                }
                
            }
            word += generated.ToString();
        }

        return word[k-1];
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Find the K-th Character in String Game I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
	}
}