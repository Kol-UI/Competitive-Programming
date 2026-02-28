// Largest Rectangle in Histogram

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.LargestRectangleinHistogram
{
    public class Solution
    {
        public static int LargestRectangleArea(int[] heights)
        {
            Stack<(int index, int height)> stack = new Stack<(int, int)>();

            int index = 0, i = 0, maxArea = 0;

            (int index, int height) top;

            stack.Push((0, heights[0]));

            for (i = 1; i < heights.Length; i++)
            {
                index = i;
                while (stack.Count > 0 && stack.Peek().height > heights[i])
                {
                    top = stack.Pop();
                    maxArea = Math.Max(maxArea, (top.height * (i - top.index)));
                    index = top.index;
                }
                stack.Push((index, heights[i]));
            }

            while (stack.Count > 0)
            {
                top = stack.Pop();
                maxArea = Math.Max(maxArea, top.height * (heights.Length - top.index));
            }

            return maxArea;
        }
    }

    public class Solution2
    {
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            int n = heights.Length;
            for (int i = 0; i < n; i++)
            {
                int minHeight = heights[i];
                for (int j = i; j < n; j++)
                {
                    minHeight = System.Math.Min(minHeight, heights[j]);
                    int currentArea = minHeight * (j - i + 1);
                    maxArea = System.Math.Max(maxArea, currentArea);
                }
            }
            return maxArea;
        }
    }
    
    public class Solution3
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int maxArea = 0;

            for (int i = 0; i < n; i++)
            {
                int height = heights[i];
                int rightMost = i + 1;
                while (rightMost < n && heights[rightMost] >= height)
                {
                    rightMost++;
                }

                int leftMost = i;
                while (leftMost >= 0 && heights[leftMost] >= height)
                {
                    leftMost--;
                }
                rightMost--;
                leftMost++;

                maxArea = Math.Max(maxArea, height * (rightMost - leftMost + 1));
            }
            return maxArea;
        }
    }

    public class Solution4
    {
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            int n = heights.Length;

            for (int i = 0; i < n; i++)
            {
                if (i < n - 1 && heights[i] <= heights[i + 1])
                {
                    continue;
                }

                int minHeight = heights[i];
                for (int j = i; j >= 0; j--)
                {
                    minHeight = System.Math.Min(minHeight, heights[j]);
                    int currentArea = minHeight * (i - j + 1);
                    maxArea = System.Math.Max(maxArea, currentArea);
                }
            }

            return maxArea;
        }
    }

    public class MinIdx_Segtree
    {
        private int n;
        private readonly int INF = (int)1e9;
        private int[] A, tree;

        public MinIdx_Segtree(int N, int[] heights)
        {
            this.n = N;
            this.A = new int[heights.Length];
            heights.CopyTo(this.A, 0);
            
            while ((n & (n - 1)) != 0)
            {
                Array.Resize(ref A, n + 1);
                A[n] = INF;
                n++;
            }
            tree = new int[2 * n];
            Build();
        }

        private void Build()
        {
            for (int i = 0; i < n; i++) tree[n + i] = i;
            for (int j = n - 1; j >= 1; j--)
            {
                int a = tree[j << 1];
                int b = tree[(j << 1) + 1];
                tree[j] = A[a] <= A[b] ? a : b;
            }
        }

        public int Query(int ql, int qh)
        {
            return Query(1, 0, n - 1, ql, qh);
        }

        private int Query(int node, int l, int h, int ql, int qh)
        {
            if (ql > h || qh < l) return INF;
            if (l >= ql && h <= qh) return tree[node];
            int a = Query(node << 1, l, (l + h) >> 1, ql, qh);
            int b = Query((node << 1) + 1, ((l + h) >> 1) + 1, h, ql, qh);
            if (a == INF) return b;
            if (b == INF) return a;
            return A[a] <= A[b] ? a : b;
        }
    }

    public class Solution5
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            if (n == 0) return 0;
            MinIdx_Segtree st = new MinIdx_Segtree(n, heights);
            return GetMaxArea(heights, 0, n - 1, st);
        }

        private int GetMaxArea(int[] heights, int l, int r, MinIdx_Segtree st)
        {
            if (l > r) return 0;
            if (l == r) return heights[l];

            int minIdx = st.Query(l, r);
            int currentArea = (r - l + 1) * heights[minIdx];

            return Math.Max(
                currentArea,
                Math.Max(GetMaxArea(heights, l, minIdx - 1, st),
                        GetMaxArea(heights, minIdx + 1, r, st))
            );
        }
    }

    public class Solution6
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int[] leftMost = new int[n];
            int[] rightMost = new int[n];
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                leftMost[i] = -1; 
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    leftMost[i] = stack.Peek();
                }
                stack.Push(i);
            }

            stack.Clear();

            for (int i = n - 1; i >= 0; i--)
            {
                rightMost[i] = n;
                while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    rightMost[i] = stack.Peek();
                }
                stack.Push(i);
            }

            int maxArea = 0;
            for (int i = 0; i < n; i++)
            {
                int left = leftMost[i] + 1;
                int right = rightMost[i] - 1;
                
                int currentArea = heights[i] * (right - left + 1);
                maxArea = Math.Max(maxArea, currentArea);
            }

            return maxArea;
        }
    }

    public class Solution7
    {
        public int LargestRectangleArea(int[] heights)
        {
            int maxArea = 0;
            Stack<int[]> stack = new Stack<int[]>();

            for (int i = 0; i < heights.Length; i++)
            {
                int start = i;

                while (stack.Count > 0 && stack.Peek()[1] > heights[i])
                {
                    int[] top = stack.Pop();
                    int index = top[0];
                    int height = top[1];

                    maxArea = Math.Max(maxArea, height * (i - index));
                    start = index;
                }

                stack.Push(new int[] { start, heights[i] });
            }
            
            foreach (int[] pair in stack)
            {
                int index = pair[0];
                int height = pair[1];
                maxArea = Math.Max(maxArea, height * (heights.Length - index));
            }

            return maxArea;
        }
    }

    public class Solution8
    {
        public int LargestRectangleArea(int[] heights)
        {
            Stack<int> stack = new Stack<int>();
            int maxArea = 0;
            int index = 0;

            while (index < heights.Length)
            {
                if (stack.Count == 0 || heights[index] >= heights[stack.Peek()])
                {
                    stack.Push(index++);
                }
                else
                {
                    int top = stack.Pop();
                    int area = heights[top] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                    
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }

            while (stack.Count > 0)
            {
                int top = stack.Pop();
                int area = heights[top] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                if (area > maxArea)
                {
                    maxArea = area;
                }
            }

            return maxArea;
        }
    }

    public class Solution9
    {
        public int LargestRectangleArea(int[] heights)
        {
            int n = heights.Length;
            int maxArea = 0;
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i <= n; i++)
            {
                int currentHeight = (i == n) ? 0 : heights[i];
                while (stack.Count > 0 && heights[stack.Peek()] >= currentHeight)
                {
                    int height = heights[stack.Pop()];
                    int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                    maxArea = Math.Max(maxArea, height * width);
                }
                stack.Push(i);
            }
            
            return maxArea;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution2 sol2 = new();
            Solution3 sol3 = new();
            Solution4 sol4 = new();
            Solution5 sol5 = new();
            Solution6 sol6 = new();
            Solution7 sol7 = new();
            Solution8 sol8 = new();
            Solution9 sol9 = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(Solution.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol2.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol2.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol2.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol2.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol3.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol3.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol3.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol3.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol4.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol4.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol4.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol4.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol5.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol5.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol5.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol5.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol6.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol6.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol6.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol6.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol7.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol7.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol7.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol7.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol8.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol8.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol8.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol8.LargestRectangleArea([1,3,7]), 7),
                ResultTester.CheckResult<int>(sol9.LargestRectangleArea([2,1,5,6,2,3]), 10),
                ResultTester.CheckResult<int>(sol9.LargestRectangleArea([2,4]), 4),
                ResultTester.CheckResult<int>(sol9.LargestRectangleArea([7,1,7,2,2,4]), 8),
                ResultTester.CheckResult<int>(sol9.LargestRectangleArea([1,3,7]), 7),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Largest Rectangle in Histogram");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}