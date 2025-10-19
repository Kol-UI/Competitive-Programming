// Lexicographically Smallest String After Applying Operations
namespace CompetitiveProgramming.LeetCode.LexicographicallySmallestStringAfterApplyingOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string FindLexSmallestString(string s, int a, int b)
    {
        int n = s.Length;

        int[] bestAdd = new int[10];
        for (int d = 0; d < 10; d++) {
            int minVal = d, minStep = 0;
            for (int step = 1; step < 10; step++) {
                int newVal = (d + a * step) % 10;
                if (newVal < minVal) {
                    minVal = newVal;
                    minStep = step;
                }
            }
            bestAdd[d] = minStep;
        }

        bool[] visited = new bool[n];
        int idx = 0;
        while (!visited[idx]) {
            visited[idx] = true;
            idx = (idx + b) % n;
        }

        string answer = s;

        for (int start = 0; start < n; start++) {
            if (!visited[start]) continue;
            string rotated = s.Substring(start) + s.Substring(0, start);

            int evenAdd = 0, oddAdd = 0;
            if (n == 1) {
                evenAdd = bestAdd[rotated[0] - '0'];
            } else {
                evenAdd = (b % 2 == 1) ? bestAdd[rotated[0] - '0'] : 0;
                oddAdd  = bestAdd[rotated[1] - '0'];
            }

            char[] chars = rotated.ToCharArray();
            for (int j = 0; j < n; j++) {
                int d = chars[j] - '0';
                int times = (j % 2 == 0) ? evenAdd : oddAdd;
                d = (d + times * a) % 10;
                chars[j] = (char)('0' + d);
            }

            string candidate = new string(chars);
            if (string.Compare(candidate, answer, StringComparison.Ordinal) < 0) {
                answer = candidate;
            }
        }

        return answer;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lexicographically Smallest String After Applying Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}