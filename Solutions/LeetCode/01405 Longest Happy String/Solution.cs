// Longest Happy String

using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestHappyString
{
    public class Solution {
        public string LongestDiverseString(int a, int b, int c) {
            var pq = new PriorityQueue<(string, int), int>();
            if (a > 0) pq.Enqueue(("a", a), -a);
            if (b > 0) pq.Enqueue(("b", b), -b);
            if (c > 0) pq.Enqueue(("c", c), -c);

            var builder = new StringBuilder();

            while(pq.Count > 0)
            {
                var list = new List<(string, int)>();

                while (list.Count < 2 && pq.Count > 0)
                {
                    var (ch, amount) = pq.Dequeue();
                    var optimalAmount = list.Count > 0 && list[^1].Item2 > amount ? 1 : 2;
                    var availableChars = Math.Min(amount, optimalAmount);
                    
                    builder.Append(string.Concat(Enumerable.Repeat(ch, availableChars)));    

                    var newAmount = amount - availableChars;
                    list.Add((ch, newAmount));
                }
                
                if (list.Count > 1)
                    list.ForEach(pair => {
                        if (pair.Item2 > 0) pq.Enqueue(pair, -pair.Item2);
                    });   
            }

            return builder.ToString();
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Happy String");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}