// Find the Original Typed String II
namespace CompetitiveProgramming.LeetCode.FindtheOriginalTypedStringII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    const int M = 1000000007;
    
    public int PossibleStringCount(string word, int k) {
        int previousCount = 1;
        List<int> options = new();
        long total = 1;
        k--;

        for (int i = 1; i < word.Length; i++) {
            if (word[i] == word[i - 1]) {
                previousCount++;
            } else {
                k--;

                if (previousCount > 1) {
                    options.Add(previousCount);
                    total = total * previousCount % M;
                }

                previousCount = 1;
            }
        }

        if (previousCount > 1) {
            options.Add(previousCount);
            total *= previousCount;
        }

        if (k > 0) {
            long[,] less = new long[k, 2];

            less[0, 0] = 1;
            less[0, 1] = 1;

            for (int i = 0; i < options.Count; i++) {
                int c = i % 2;
                int p = (i + 1) % 2;

                for (int j = 1, j2 = 1 - options[i]; j < k; j++, j2++) {
                    less[j, c] = (less[j - 1, c] + less[j, p] - (j2 > -1 ? less[j2, p] : 0)) % M;
                    if (less[j, c] == 0) break;
                }
            }

            int l = (options.Count - 1) % 2;
            for (int i = 0; i < k; i++) {
                total -= less[i, l];
            }
        }

        while (total < 0) {
            total += M;
        }

        return (int)(total % M);
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Find the Original Typed String II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
	}
}