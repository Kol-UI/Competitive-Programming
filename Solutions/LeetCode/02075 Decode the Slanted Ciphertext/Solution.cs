// Decode the Slanted Ciphertext
namespace CompetitiveProgramming.LeetCode.DecodetheSlantedCiphertext;

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string DecodeCiphertext(string encodedText, int rows)
    {
        int len = encodedText.Length;
        int cols = len / rows;
        StringBuilder res = new StringBuilder();

        for (int c = 0; c < cols; c++)
        {
            int cR = 0, cC = c;
            while (cR < rows && cC < cols)
            {
                int idx = cR * cols + cC;

                res.Append(encodedText[idx]);
                cR++;
                cC++;

            }
        }

        string tmp = res.ToString();
        tmp = tmp.TrimEnd();
        return tmp;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.DecodeCiphertext("ch   ie   pr", 3), "cipher"),
            ResultTester.CheckResult<string>(solution.DecodeCiphertext("iveo    eed   l te   olc", 4), "i love leetcode"),
            ResultTester.CheckResult<string>(solution.DecodeCiphertext("coding", 1), "coding"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Decode the Slanted Ciphertext");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}