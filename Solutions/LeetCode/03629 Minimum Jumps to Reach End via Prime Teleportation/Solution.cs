// Minimum Jumps to Reach End via Prime Teleportation
namespace CompetitiveProgramming.LeetCode.MinimumJumpstoReachEndviaPrimeTeleportation;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

/*
public class Solution
{
    public int MinJumps(int[] nums)
    {
        Dictionary<int, List<int>> portals = Portals(nums);
        return BFS(nums, portals);
    }
    
    private static int BFS(int[] nums, Dictionary<int, List<int>> portals)
    {
        HashSet<int> alreadyVisited = [0];
        Queue<(int position, int jumps)> queue = new();
        queue.Enqueue((0,0));
        
        while (queue.Count > 0)
        {
            (int position, int jumps) = queue.Dequeue();
            if (position == nums.Length-1)
            {
                return jumps;
            }

            int next = position+1;
            if (!alreadyVisited.Contains(next))
            {
                alreadyVisited.Add(next);
                queue.Enqueue((next, jumps+1));
            }

            if (position > 1)
            {
                 next = position-1;
                if (!alreadyVisited.Contains(next))
                {
                    alreadyVisited.Add(next);
                    queue.Enqueue((next, jumps+1));
                }
            }

            if (portals.TryGetValue(nums[position], out var portal))
            {
                for (int i = 0; i < portal.Count; i++)
                {
                    next = portal[i];
                    if (!alreadyVisited.Contains(next))
                    {
                        alreadyVisited.Add(next);
                        queue.Enqueue((next, jumps+1));
                    }
                }
                portals.Remove(nums[position]);
            }
        }

        return -1;
    }

    private static Dictionary<int, List<int>> Portals(int[] nums)
    {
        Dictionary<int, List<int>> primesFromArray = FindPrimes(nums);
        Dictionary<int, List<int>> primeFactors = PrimeMultiples(nums, primesFromArray.Keys);
        FindPortals(nums, ref primesFromArray, primeFactors);
        return primesFromArray;
    }
    
    private static Dictionary<int, List<int>> FindPrimes(int[] nums)
    {
        HashSet<int> primesKnownSoFar = [2];
        List<int> primesKnownSoFarSorted = [2];
        Dictionary<int, List<int>> primesFromArray = new(capacity:nums.Length);
        
        foreach (int x in nums.Where(x => IsPrime(x, ref primesKnownSoFar, ref primesKnownSoFarSorted)))
        {
            primesFromArray.TryAdd(x, []);
        }

        return primesFromArray;
    }        
    
    private static bool IsPrime(int x, ref HashSet<int> primesKnownSoFar, ref List<int> sorted)
    {
        if (x > sorted[^1])
        {
            for (int i = sorted[^1]+1; i <= x; i++)
            {
                bool isPrime = true;
                for (int j = 0; j < sorted.Count && sorted[j]*sorted[j] <= i; j++)
                {
                    if (i % sorted[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {                    
                    primesKnownSoFar.Add(i);
                    sorted.Add(i);
                }
            }            
        }

        return primesKnownSoFar.Contains(x);
    }

    private static Dictionary<int, List<int>> PrimeMultiples(int[] nums, IEnumerable<int> primesFromArray)
    {
        int max = nums.Max();
        Dictionary<int, List<int>> primeFactors = [];
        
        foreach (int p in primesFromArray)
        {
            for (int j = p; j <= max; j += p)
            {
                if (primeFactors.TryGetValue(j, out List<int>? list))
                {
                    list.Add(p);
                }
                else
                {
                    primeFactors.Add(j, new(capacity: 4) { p });
                }
            }
        }

        return primeFactors;
    }
    
    private static void FindPortals(int[] nums, ref Dictionary<int, List<int>> portals, Dictionary<int, List<int>> primeFactorizations)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int x = nums[i];
            if (primeFactorizations.TryGetValue(x, out List<int>? primeFactors))
            {
                for (int j = 0; j < primeFactors.Count; j++)
                {
                    int p = primeFactors[j];
                    if (x % p == 0)
                    {
                        portals[p].Add(i);
                    }
                }
            }
        }
    }
}
*/

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Jumps to Reach End via Prime Teleportation");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}