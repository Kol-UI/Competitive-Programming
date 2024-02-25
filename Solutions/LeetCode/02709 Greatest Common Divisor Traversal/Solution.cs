// Greatest Common Divisor Traversal


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.GreatestCommonDivisorTraversal
{
    public class Solution
    {
        public class UnionFind
        {
            public int[] par;
            public int[] size;
            public int count;

            public UnionFind(int n)
            {
                count = n;
                par = new int[n];
                size = new int[n];
                for(int i = 0; i < n; i++)
                {
                    par[i] = i;
                    size[i] = 1;
                }
            }

            public int Find(int n)
            {
                if(n != par[n])
                {
                    par[n] = Find(par[n]);
                }

                return par[n];
            }

            public void Union(int x, int y)
            {
                var px = Find(x);
                var py = Find(y);

                if(px == py)
                {
                    return;
                }

                if(size[px] < size[py])
                {
                    par[px] = py;
                    size[py] += size[px];
                }
                else
                {
                    par[py] = px;
                    size[px] += size[py];
                }
                
                count--;
            }
        }
        
        public bool CanTraverseAllPairs(int[] nums)
        {
            int n = nums.Length;
            UnionFind uf = new UnionFind(n);
            Dictionary<int, int> primeToIndex = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                List<int> primes = PrimeFactors(nums[i]);

                foreach (int prime in primes)
                {
                    if (!primeToIndex.ContainsKey(prime))
                    {
                        primeToIndex[prime] = i;
                    }
                    else
                    {
                        uf.Union(i, primeToIndex[prime]);
                    }
                }
            }

            return uf.count == 1;
        }

        private List<int> PrimeFactors(int num)
        {
            List<int> primes = new List<int>();

            for (int i = 2; i * i <= num; i++)
            {
                while (num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
            }

            if (num > 1)
                primes.Add(num);

            return primes;
        }
    }
}