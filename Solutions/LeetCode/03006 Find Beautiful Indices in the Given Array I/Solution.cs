// Find Beautiful Indices in the Given Array I
namespace CompetitiveProgramming.LeetCode.FindBeautifulIndicesintheGivenArrayI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> BeautifulIndices(string s, string a, string b, int k)
    {
        int lenS = s.Length, lenA = a.Length, lenB = b.Length;
        Queue<int> AIds = new(), BIds = new();
        List<int> resIds = new();
        int uplimit = lenS - Math.Min(lenA, lenB);

        for(int i = 0; i <= uplimit; i++)
        {
            if(i + lenA <= lenS)
            {
                if(s.Substring(i, lenA) == a)
                {
                    while(BIds.Count > 0 && i-BIds.Peek() > k) 
                    {
                        BIds.Dequeue();
                    }

                    if(BIds.Count > 0)
                        resIds.Add(i);
                    else
                        AIds.Enqueue(i);
                }
            }

            if(i + lenB <= lenS)
            {
                if(s.Substring(i, lenB) == b)
                {   
                    while(AIds.Count > 0 && i- AIds.Peek() > k)
                    {
                        AIds.Dequeue();
                    }

                    while(AIds.Count > 0)
                    {
                        resIds.Add(AIds.Dequeue());
                    }

                    BIds.Enqueue(i);
                }
            }

        }

        return resIds;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Beautiful Indices in the Given Array I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}