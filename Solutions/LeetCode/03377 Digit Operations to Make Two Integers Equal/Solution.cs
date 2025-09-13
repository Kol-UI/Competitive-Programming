// Digit Operations to Make Two Integers Equal
namespace CompetitiveProgramming.LeetCode.DigitOperationstoMakeTwoIntegersEqual;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8618
public class Solution
{
    private bool[] validPrime;
    private void CalPrimes()
    {
        validPrime[0] = false;
        validPrime[1] = false;
        for (int i = 2; i < 10000; i++)
        {
            if (!validPrime[i])
                continue;

            int j = i * 2;
            while (j < 10000)
            {
                validPrime[j] = false;
                j += i;
            }
        }
    }

    public int MinOperations(int n, int m)
    {
        validPrime = Enumerable.Repeat(true, 10001).ToArray();
        CalPrimes();

        if (validPrime[n])
            return -1;

        HashSet<int> visited = new();
        PriorityQueue<int, int> pq = new();
        pq.Enqueue(n, n);
        while (pq.TryDequeue(out int num, out int step))
        {
            if (num == m)
                return step;

            for (int dig = 1; dig < 10000; dig *= 10)
            {
                int rest = (num / dig);
                if (rest == 0)
                    break;

                if (rest % 10 != 9)
                {
                    rest++;
                    int nextNum = rest * dig + num % dig;
                    if (!validPrime[nextNum] && visited.Add(nextNum))
                    {
                        if (nextNum == m)
                            return step + nextNum;

                        pq.Enqueue(nextNum, step + nextNum);
                    }

                    rest--;
                }

                if (rest % 10 > 0)
                {
                    if (--rest == 0)
                        continue;

                    int nextNum = rest * dig + num % dig;

                    if (!validPrime[nextNum] && visited.Add(nextNum))
                    {
                        if (nextNum == m)
                            return step + nextNum;

                        pq.Enqueue(nextNum, step + nextNum);
                    }
                }
            }
        }

        return -1;
    }
}
#pragma warning restore CS8618

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Digit Operations to Make Two Integers Equal");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}