// Reverse Odd Levels of Binary Tree

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ReverseOddLevelsofBinaryTree
{
    public class Solution
    {
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            if (root == null)
                return null!;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int level = 0;

            while (queue.Count > 0)
            {
                int size = queue.Count;
                List<TreeNode> currentLevelNodes = new List<TreeNode>();

                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();
                    currentLevelNodes.Add(node);

                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                }

                if (level % 2 == 1)
                {
                    int left = 0;
                    int right = currentLevelNodes.Count - 1;

                    while (left < right)
                    {
                        int temp = currentLevelNodes[left].val;
                        currentLevelNodes[left].val = currentLevelNodes[right].val;
                        currentLevelNodes[right].val = temp;

                        left++;
                        right--;
                    }
                }

                level++;
            }

            return root;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            TreeNode case1 = new TreeNode(2,
                new TreeNode(3,
                    new TreeNode(8),
                    new TreeNode(13)
                ),
                new TreeNode(5,
                    new TreeNode(21),
                    new TreeNode(34)
                )
            );

            TreeNode result1 = new TreeNode(2,
                new TreeNode(5,
                    new TreeNode(8),
                    new TreeNode(13)
                ),
                new TreeNode(3,
                    new TreeNode(21),
                    new TreeNode(34)
                )
            );

            TreeNode case2 = new TreeNode(0,
                new TreeNode(1,
                    new TreeNode(0,
                        new TreeNode(1),
                        new TreeNode(1)
                    ),
                    new TreeNode(0,
                        new TreeNode(1),
                        new TreeNode(1)
                    )
                ),
                new TreeNode(2,
                    new TreeNode(0,
                        new TreeNode(2),
                        new TreeNode(2)
                    ),
                    new TreeNode(0,
                        new TreeNode(2),
                        new TreeNode(2)
                    )
                )
            );

            TreeNode result2 = new TreeNode(0,
                new TreeNode(2,
                    new TreeNode(0,
                        new TreeNode(2),
                        new TreeNode(2)
                    ),
                    new TreeNode(0,
                        new TreeNode(2),
                        new TreeNode(2)
                    )
                ),
                new TreeNode(1,
                    new TreeNode(0,
                        new TreeNode(1),
                        new TreeNode(1)
                    ),
                    new TreeNode(0,
                        new TreeNode(1),
                        new TreeNode(1)
                    )
                )
            );

            TreeNode case3 = new TreeNode(7,
                new TreeNode(13),
                new TreeNode(11)
            );

            TreeNode result3 = new TreeNode(7,
                new TreeNode(11),
                new TreeNode(13)
            );
            
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<TreeNode>(solution.ReverseOddLevels(case1), result1),
                ResultTester.CheckResult<TreeNode>(solution.ReverseOddLevels(case2), result2),
                ResultTester.CheckResult<TreeNode>(solution.ReverseOddLevels(case3), result3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reverse Odd Levels of Binary Tree");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}