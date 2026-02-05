// Most Popular Video Creator
namespace CompetitiveProgramming.LeetCode.MostPopularVideoCreator;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<IList<string>> MostPopularCreator(string[] creators, string[] ids, int[] views)
    {
        Dictionary<string, (long, string, int)> map = new Dictionary<string, (long, string, int)>();
        int n = creators.Length;
        IList<IList<string>> result = new List<IList<string>>();
        long maxView = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (!map.ContainsKey(creators[i]))
            {
                map.Add(creators[i], (views[i], ids[i], views[i]));
                maxView = Math.Max(maxView, views[i]);
            }
            else
            {
                (long totalviews, string id, int view) = map[creators[i]];

                totalviews += views[i];

                maxView = Math.Max(maxView, totalviews);
                if (view < views[i])
                {
                    id = ids[i];
                    view = views[i];
                }
                else if (view == views[i] && string.Compare(id, ids[i]) == 1)
                {
                    id = ids[i];
                }

                map[creators[i]] = (totalviews, id, view);
            }
        }

        foreach (string creator in map.Keys)
        {
            if(map[creator].Item1 == maxView)
            {
                result.Add(new List<string>() { creator, map[creator].Item2 });
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
        StyleHelper.Title("Most Popular Video Creator");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}