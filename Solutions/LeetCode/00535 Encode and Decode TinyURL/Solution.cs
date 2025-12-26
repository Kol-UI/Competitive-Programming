// Encode and Decode TinyURL
namespace CompetitiveProgramming.CodeForces.EncodeandDecodeTinyURL;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Codec
{
    private Dictionary<string, int> dic = new Dictionary<string, int>();
    private Dictionary<int, string> dic2 = new Dictionary<int, string>();

    public string encode(string longUrl)
    {
        if (!dic.ContainsKey(longUrl))
        {
            dic.Add(longUrl, dic2.Count);
            dic2.Add(dic2.Count, longUrl);
        }
        return dic[longUrl].ToString();
    }

    public string decode(string shortUrl) => dic2[Convert.ToInt32(shortUrl)];
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Encode and Decode TinyURL");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}