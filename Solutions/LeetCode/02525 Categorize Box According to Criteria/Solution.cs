// Categorize Box According to Criteria


using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CategorizeBoxAccordingtoCriteria
{
    public class Solution
    {
        public static string CategorizeBox(int length, int width, int height, int mass)
        {
            Category category = Category.Neither;
            var dimensions = new[] { length, width, height };

            if(dimensions.Max() >= 1e4 || dimensions.Aggregate(1L, (x, y) => x * y) >= 1e9)
                category |= Category.Bulky;

            if(mass >= 100)
                category |= Category.Heavy;

            return category.ToString();
        }
        
        enum Category
        {
            Neither,
            Bulky,
            Heavy,
            Both
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<string>(Solution.CategorizeBox(1000, 35, 700, 300), "Heavy"),
                ResultTester.CheckResult<string>(Solution.CategorizeBox(200, 50, 800, 50), "Neither"),
            };
            return results;
        }
    }
}