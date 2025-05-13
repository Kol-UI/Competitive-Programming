// Total Characters in String After Transformations I
namespace CompetitiveProgramming.LeetCode.TotalCharactersinStringAfterTransformationsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
using Xunit;

public class Solution
{
	private const int Modulo = 1000000007;

	public int LengthAfterTransformations(string s, int t)
	{
		int max = 25;
		int max2 = max + 1;
		long[] counts = new long[max2];
		long finalLength = 0;

		foreach (char c in s) counts[c - 'a']++;

		for (int i = 0; i < t; i++)
		{
			long[] nextCounts = new long[max2];
			long zCount = counts[max];

			for (int j = 0; j < max; j++)
			{
				nextCounts[j + 1] = (nextCounts[j + 1] + counts[j]) % Modulo;
			}

			nextCounts[0] = (nextCounts[0] + zCount) % Modulo;
			nextCounts[1] = (nextCounts[1] + zCount) % Modulo;

			counts = nextCounts;
		}

		for (int j = 0; j < max2; j++) finalLength = (finalLength + counts[j]) % Modulo;

		return (int)finalLength;
	}
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Total Characters in String After Transformations I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}