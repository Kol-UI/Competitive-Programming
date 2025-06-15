// Max Difference You Can Get From Changing an Integer
namespace CompetitiveProgramming.LeetCode.MaxDifferenceYouCanGetFromChanginganInteger;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxDiff(int num) {
        int max1 = 0;
        int min1 = 0;

        char[] max = num.ToString().ToCharArray();
        char[] min = num.ToString().ToCharArray();
        char val = '\0';
        char val1 = '\0';

        for (int i = 0; i < max.Length; i++) {
            if (max[i] != '9') {
                val = max[i];
                break;
            }
        }

        for (int i = 0; i < max.Length; i++) {
            if (max[i] == val) {
                max[i] = '9';
            }
        }

        if (min[0] != '1') {
            val1 = min[0];
            for (int i = 0; i < min.Length; i++) {
                if (min[i] == val1) {
                    min[i] = '1';
                }
            }
        }
        else {
            for (int i = 1; i < min.Length; i++) {
                if (min[i] != '0' && min[i] != '1') {
                    val1 = min[i];
                    for (int j = 0; j < min.Length; j++) {
                        if (min[j] == val1) {
                            min[j] = '0';
                        }
                    }
                    break;
                }
            }
        }

        max1 = int.Parse(new string(max));
        min1 = int.Parse(new string(min));
        return max1 - min1;
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Max Difference You Can Get From Changing an Integer");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}