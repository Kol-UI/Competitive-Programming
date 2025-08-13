// Maximize Amount After Two Days of Conversions
namespace CompetitiveProgramming.LeetCode.MaximizeAmountAfterTwoDaysofConversions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public double MaxAmount(string initialCurrency, IList<IList<string>> pairs1, double[] rates1, IList<IList<string>> pairs2, double[] rates2)
    {
        var dic0 = CreateDic(pairs1, rates1);
        var dic1 = CreateDic(pairs2, rates2);
        var firstDay = CalculateCurres(initialCurrency, 1, dic0);
        double rs = 1;
        foreach(var item in firstDay)
        {
            var rs0 = CalculateCurres(item.Key, item.Value, dic1);
            if (rs0.ContainsKey(initialCurrency))
            {
                rs = Math.Max(rs, rs0[initialCurrency]);
            }
        }
        return rs;
    }

    private Dictionary<string, double> CalculateCurres(string initialCurrency, double initialValue, Dictionary<string, List<(string targetCurrency, double rate)>> dic)
    {
        var aux = new Dictionary<string, double>();
        List<string> keys = dic.Keys.ToList();
        for (int i = 0; i < keys.Count; i++)
        {
            aux.Add(keys[i], 0);
        }
        aux[initialCurrency] = initialValue;
        var cont = true;
        var border = new Dictionary<string, double>();
        border.Add(initialCurrency, initialValue);
        while (cont)
        {
            cont = false;
            var border2 = new Dictionary<string, double>();
            foreach (KeyValuePair<string, double> item in border)
            {//
                if (!dic.ContainsKey(item.Key)) continue;
                foreach ((string targetCurrency, double rate) item2 in dic[item.Key])
                {
                    string newCurrency = item2.targetCurrency;
                    double newCurrencyValue = item.Value * item2.rate;
                    if (!border2.ContainsKey(newCurrency))
                    {
                        if (aux[newCurrency] < newCurrencyValue)
                        {
                            aux[newCurrency] = newCurrencyValue;
                            border2.Add(newCurrency, newCurrencyValue);
                            cont = true;
                        }
                    }
                    else
                    {
                        if (border2[newCurrency] < newCurrencyValue)
                        {
                            border2[newCurrency] = newCurrencyValue;
                            cont = true;
                        }
                    }
                }
            }
            border = border2;
        }
        return aux;
    }

    private Dictionary<string, List<(string targetCurrency, double rate)>> CreateDic(IList<IList<string>> pairs, double[] rates)
    {
        var rs = new Dictionary<string, List<(string targetCurrency, double rate)>>();
        for (int i = 0; i < pairs.Count; i++)
        {
            if (!rs.ContainsKey(pairs[i][0])) rs.Add(pairs[i][0], new List<(string targetCurrency, double rate)>());
            rs[pairs[i][0]].Add((pairs[i][1], rates[i]));
            if (!rs.ContainsKey(pairs[i][1])) rs.Add(pairs[i][1], new List<(string targetCurrency, double rate)>());
            rs[pairs[i][1]].Add((pairs[i][0], 1 / rates[i]));
        }
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Amount After Two Days of Conversions");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}