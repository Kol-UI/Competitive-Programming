// Find All Numbers Disappeared in an Array

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllNumbersDisappearedinanArray
{
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                {
                    nums[index] = -nums[index];
                }
            }

            List<int> missingNumbers = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    missingNumbers.Add(i + 1);
                }
            }

            return missingNumbers;
        }
    }

    public class SolutionBruteForce
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();
            int n = nums.Length;

            for (int i = 1; i <= n; i++)
            {
                bool found = false;

                for (int j = 0; j < n; j++)
                {
                    if (nums[j] == i)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    result.Add(i);
            }

            return result;
        }
    }

    public class SolutionOptimal
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            var result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int index = Math.Abs(nums[i]) - 1;
                if (nums[index] > 0)
                    nums[index] = -nums[index];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    result.Add(i + 1);
            }

            return result;
        }
    }

    public class SolutionLinqHashSet
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;
            var set = nums.ToHashSet();

            return Enumerable
                .Range(1, n)
                .Where(x => !set.Contains(x))
                .ToList();
        }
    }

    public class SolutionExtraArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;
            bool[] seen = new bool[n + 1];

            foreach (int num in nums)
                seen[num] = true;

            var result = new List<int>();
            for (int i = 1; i <= n; i++)
                if (!seen[i])
                    result.Add(i);

            return result;
        }
    }

    public class SolutionCycleSort
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                int correctIndex = nums[i] - 1;
                if (nums[i] != nums[correctIndex])
                {
                    int temp = nums[i];
                    nums[i] = nums[correctIndex];
                    nums[correctIndex] = temp;
                }
                else
                {
                    i++;
                }
            }

            var result = new List<int>();
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                    result.Add(i + 1);
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            SolutionBruteForce bruteForce = new();
            SolutionOptimal optimal = new();
            SolutionExtraArray extraArray = new();
            SolutionCycleSort cycleSort = new();
            SolutionLinqHashSet linqHashSet = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<int>>(solution.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(solution.FindDisappearedNumbers([1, 1]), [2]),
                ResultTester.CheckResult<IList<int>>(bruteForce.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(bruteForce.FindDisappearedNumbers([1, 1]), [2]),
                ResultTester.CheckResult<IList<int>>(optimal.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(optimal.FindDisappearedNumbers([1, 1]), [2]),
                ResultTester.CheckResult<IList<int>>(extraArray.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(extraArray.FindDisappearedNumbers([1, 1]), [2]),
                ResultTester.CheckResult<IList<int>>(cycleSort.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(cycleSort.FindDisappearedNumbers([1, 1]), [2]),
                ResultTester.CheckResult<IList<int>>(linqHashSet.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]), [5, 6]),
                ResultTester.CheckResult<IList<int>>(linqHashSet.FindDisappearedNumbers([1, 1]), [2]),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find All Numbers Disappeared in an Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}