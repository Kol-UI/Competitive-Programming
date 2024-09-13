// XOR Queries of a Subarray

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.XORQueriesofaSubarray
{
    public class Solution
    {
        public int[] XorQueries(int[] arr, int[][] queries) {
            int[] prefixXor = ComputePrefixXor(arr);
            return ComputeQueryResults(prefixXor, queries);
        }

        private int[] ComputePrefixXor(int[] arr) {
            int[] prefixXor = new int[arr.Length];
            prefixXor[0] = arr[0];
            
            for (int i = 1; i < arr.Length; i++) {
                prefixXor[i] = prefixXor[i - 1] ^ arr[i];
            }
            
            return prefixXor;
        }

        private int[] ComputeQueryResults(int[] prefixXor, int[][] queries) {
            int[] result = new int[queries.Length];
            
            for (int i = 0; i < queries.Length; i++) {
                int left = queries[i][0];
                int right = queries[i][1];
                
                if (left == 0) {
                    result[i] = prefixXor[right];
                } else {
                    result[i] = prefixXor[right] ^ prefixXor[left - 1];
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
            StyleHelper.Title("XOR Queries of a Subarray");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}