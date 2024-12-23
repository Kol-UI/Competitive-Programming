// Minimum Number of Operations to Sort a Binary Tree by Level
#nullable disable
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoSortaBinaryTreebyLevel
{
    public class Solution
    {
        public int MinimumOperations(TreeNode root)
        {
            if (root == null)
                return 0;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            int totalSwaps = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                List<int> levelValues = new List<int>();

                for (int i = 0; i < levelSize; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    levelValues.Add(currentNode.val);

                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                }

                totalSwaps += CountSwapsToSort(levelValues);
            }

            return totalSwaps;
        }

        private int CountSwapsToSort(List<int> values)
        {
            int[] sortedValues = values.ToArray();
            Array.Sort(sortedValues);
            Dictionary<int, int> valueToIndex = new Dictionary<int, int>();

            for (int i = 0; i < values.Count; i++)
            {
                valueToIndex[values[i]] = i;
            }

            bool[] visited = new bool[values.Count];
            int swaps = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (visited[i] || valueToIndex[sortedValues[i]] == i)
                    continue;

                int cycleSize = 0;
                int j = i;

                while (!visited[j])
                {
                    visited[j] = true;
                    j = valueToIndex[sortedValues[j]];
                    cycleSize++;
                }

                if (cycleSize > 1)
                    swaps += cycleSize - 1;
            }

            return swaps;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            TreeNode root1 = new TreeNode(1,
                new TreeNode(4,
                    new TreeNode(7),
                    new TreeNode(6)
                ),
                new TreeNode(3,
                    new TreeNode(8,
                        new TreeNode(9,
                            new TreeNode(10),
                            null
                        ),
                        null
                    ),
                    new TreeNode(5)
                )
            );

            TreeNode root2 = new TreeNode(1,
                new TreeNode(3,
                    new TreeNode(7),
                    new TreeNode(6)
                ),
                new TreeNode(2,
                    new TreeNode(5),
                    new TreeNode(4)
                )
            );

            TreeNode root3 = new TreeNode(1,
                new TreeNode(2,
                    new TreeNode(4),
                    new TreeNode(5)
                ),
                new TreeNode(3,
                    new TreeNode(6),
                    null
                )
            );

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinimumOperations(root1), 3),
                ResultTester.CheckResult<int>(solution.MinimumOperations(root2), 3),
                ResultTester.CheckResult<int>(solution.MinimumOperations(root3), 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Operations to Sort a Binary Tree by Level");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}
#nullable enable