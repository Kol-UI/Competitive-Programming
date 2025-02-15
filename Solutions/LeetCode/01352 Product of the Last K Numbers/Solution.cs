// Product of the Last K Numbers

namespace CompetitiveProgramming.LeetCode.ProductoftheLastKNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class ProductOfNumbers
{
    private List<int> prefixProduct;

    public ProductOfNumbers()
    {
        prefixProduct = new List<int>();
        prefixProduct.Add(1);
    }
    
    public void Add(int num)
    {
        if (num == 0)
        {
            prefixProduct.Clear();
            prefixProduct.Add(1); 
        }
        else
        {
            int lastProduct = prefixProduct[prefixProduct.Count - 1];
            prefixProduct.Add(lastProduct * num);
        }
    }
    
    public int GetProduct(int k)
    {
        int size = prefixProduct.Count;
        if (k >= size) return 0; 
        return prefixProduct[size - 1] / prefixProduct[size - k - 1];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Product of the Last K Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}