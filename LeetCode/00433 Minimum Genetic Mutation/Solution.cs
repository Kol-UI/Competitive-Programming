// Minimum Genetic Mutation

/*
A gene string can be represented by an 8-character long string, with choices from 'A', 'C', 'G', and 'T'.

Suppose we need to investigate a mutation from a gene string startGene to a gene string endGene where one mutation is defined as one single character changed in the gene string.

For example, "AACCGGTT" --> "AACCGGTA" is one mutation.
There is also a gene bank bank that records all the valid gene mutations. A gene must be in bank to make it a valid gene string.

Given the two gene strings startGene and endGene and the gene bank bank, return the minimum number of mutations needed to mutate from startGene to endGene. If there is no such a mutation, return -1.

Note that the starting point is assumed to be valid, so it might not be included in the bank.

 

Example 1:

Input: startGene = "AACCGGTT", endGene = "AACCGGTA", bank = ["AACCGGTA"]
Output: 1

Example 2:

Input: startGene = "AACCGGTT", endGene = "AAACGGTA", bank = ["AACCGGTA","AACCGCTA","AAACGGTA"]
Output: 2
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumGeneticMutation
{
    public class Solution
    {
        public static int MinMutation(string startGene, string endGene, string[] bank)
        {
            bool[] visited = new bool[bank.Length];
            Queue<(string str, int ct)> q = new Queue<(string, int)>();
            q.Enqueue((startGene, 0));

            while(q.Count > 0)
            {
                string rem = q.Peek().str;
                int ct = q.Peek().ct;
                if(string.Equals(rem, endGene))
                {
                    return ct;
                }

                q.Dequeue();
                int index = 0;
                
                foreach(string s in bank)
                {
                    int count = 0;
                    if(string.Equals(s, rem) || visited[index])
                    {
                        index++;
                        continue;
                    }

                    for(int i = 0; i < s.Length; i++)
                    {
                        if(count >=2 ) break;
                        if(rem[i] != s[i])
                        {
                            count++;
                        }
                    }

                    if(count == 1 && !visited[index])
                    {
                        visited[index] = true;
                        q.Enqueue((s, ct+1));
                    }

                    index++;
                }
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestMinimumGeneticMutation()
        {
            string startGene1 = "AACCGGTT";
            string endGene1 = "AACCGGTA";
            string[] bank1 = {"AACCGGTA"};
            string startGene2 = "AACCGGTT";
            string endGene2 = "AAACGGTA";
            string[] bank2 = {"AACCGGTA","AACCGCTA","AAACGGTA"};
            int result1 = Solution.MinMutation(startGene1, endGene1, bank1);
            int result2 = Solution.MinMutation(startGene2, endGene2, bank2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 1),
                ResultTester.CheckResult<int>(result2, 2)
            };
            return results;
        }
    }
}