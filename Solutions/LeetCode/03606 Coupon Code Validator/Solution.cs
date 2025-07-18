// Coupon Code Validator
namespace CompetitiveProgramming.LeetCode.CouponCodeValidator;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private Dictionary<string, int> categoryMap = new Dictionary<string, int>
    {
        { "electronics", 0 },
        { "grocery", 1 },
        { "pharmacy", 2 },
        { "restaurant", 3 }
    };

    private List<string>[] categories = new List<string>[]
    {
        new List<string>(),
        new List<string>(),
        new List<string>(),
        new List<string>() 
    };

    public IList<string> ValidateCoupons(string[] code, string[] businessLine, bool[] isActive)
    {
        var result = new List<string>();

        for (int i = 0; i < code.Length; i++)
        {
            if (isActive[i] && code[i] != string.Empty)
            {
                var isDorL = code[i].All(c => Char.IsLetterOrDigit(c) || c == '_');
                var categoriesIdx = categoryMap.GetValueOrDefault(businessLine[i], -1);
                if (isDorL && categoriesIdx != -1)
                {
                    categories[categoriesIdx].Add(code[i]);
                }
            }
        }

        foreach (var category in categories)
        {
            if (category.Count > 0)
            {
                category.Sort(StringComparer.Ordinal);
                result.AddRange(category);
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
        StyleHelper.Title("Coupon Code Validator");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}