// Shopping Offers
namespace CompetitiveProgramming.LeetCode.ShoppingOffers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ShoppingOffers(IList<int> unitCost, IList<IList<int>> discounts, IList<int> required)
    {
        int itemCount = unitCost.Count;
        Dictionary<int, int> memo = new Dictionary<int, int>();

        int ComputeHash(int[] array)
        {
            int code = 7;
            for (int i = 0; i < array.Length; i++)
                code = code * 11 + array[i];
            return code;
        }

        int FindMinimum(int[] current)
        {
            int key = ComputeHash(current);
            if (memo.ContainsKey(key)) return memo[key];

            int directCost = 0;
            for (int i = 0; i < itemCount; i++) directCost += current[i] * unitCost[i];

            foreach (var deal in discounts)
            {
                int[] remaining = new int[itemCount];
                bool valid = true;
                for (int i = 0; i < itemCount; i++)
                {
                    if (current[i] >= deal[i])
                    {
                        remaining[i] = current[i] - deal[i];
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }
                if (valid)
                {
                    directCost = Math.Min(directCost, deal[itemCount] + FindMinimum(remaining));
                }
            }

            memo[key] = directCost;
            return directCost;
        }

        return FindMinimum(required.ToArray());
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shopping Offers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}