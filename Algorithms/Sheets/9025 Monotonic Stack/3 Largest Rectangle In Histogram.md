Largest Rectangle In Histogram

You are given an array of integers heights where heights[i] represents the height of a bar. The width of each bar is 1.

Return the area of the largest rectangle that can be formed among the bars.


Example 1:

Input: heights = [7,1,7,2,2,4]

Output: 8


Example 2:

Input: heights = [1,3,7]

Output: 7


Example 3:

Input: heights = [2,1,5,6,2,3]

Output: 10


Example 4:

Input: heights = [2,4]

Output: 4


```cs
// Brute Force - Expansion from the right (All widths) Approach
// 1) Check each value
// 2) Count how far it can spread
// Fix a starting point and try all possible widths to the right
// 3) Apply height x width
// 4) Return the highest area (height x width)

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        int n = heights.Length;
        // Consider each bar as the smallest bar in the rectangle
        for (int i = 0; i < n; i++) // Step 1
        {
            int minHeight = heights[i];
            // Expand to the right
            for (int j = i; j < n; j++) // Step 2
            {
                // Update the minHeight for the current range
                minHeight = System.Math.Min(minHeight, heights[j]);
                // Calculate area with minHeight as the height
                int currentArea = minHeight * (j - i + 1); // Step 3
                maxArea = System.Math.Max(maxArea, currentArea);
            }
        }
        return maxArea; // Step 4
    }
}

// Brute Force - Expansion by height Approach
// 1) Check each value
// 2) Count how far it can spread
// It sets a height (that of the current bar) and looks for the maximum possible width for that precise height.
// 3) Apply height x width
// 4) Return the highest area (height x width)

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int maxArea = 0;

        for (int i = 0; i < n; i++) // Step 1 : Check each value
        {
            int height = heights[i];

            // Step 2 : Count how far it can spread (Left and Right)
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

            // Step 3 : Apply height x width
            maxArea = Math.Max(maxArea, height * (rightMost - leftMost + 1));
        }
        return maxArea; // Step 4 : Return the highest area
    }
}

// Better Brute Force (Pruning) Approach
// 1) Check each value (looking for a peak)
// 2) Count how far it can spread (looking backwards from the peak)
// 3) Apply height x width (using the minHeight found so far)
// 4) Return the highest area (height x width)

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        int n = heights.Length;

        for (int i = 0; i < n; i++) // Step 1: Check each value
        {
            // If the next bar is taller or equal, 
            // we don't process the current one yet because the next one 
            // will necessarily form a larger or equal rectangle.
            if (i < n - 1 && heights[i] <= heights[i + 1])
            {
                // Pruning !
                // We know in advance that they will not give a better result than what we already have
                continue;
            }

            int minHeight = heights[i];

            // Step 2: Count how far it can spread (backwards from the peak)
            for (int j = i; j >= 0; j--)
            {
                // Update the minHeight for the range [j...i]
                minHeight = System.Math.Min(minHeight, heights[j]);

                // Step 3: Apply height x width
                // Width is calculated as (i - j + 1)
                int currentArea = minHeight * (i - j + 1);
                maxArea = System.Math.Max(maxArea, currentArea);
            }
        }

        // Step 4: Return the highest area
        return maxArea;
    }
}


// Segment Tree + Divide and Conquer Approach

/*
Rather than searching for the lowest bar by traversing the entire array each time, we construct a search tree. This tree gives us the index of the lowest bar between two bounds (L and R).

Once we have the lowest bar (the weakest point), we know that the largest rectangle is either:

The one that uses this lowest bar across its entire width.

A rectangle located entirely to the left of this bar.

A rectangle located entirely to the right of this bar.
*/

// 1) Build a Segment Tree to find the index of the minimum value in any range [L, R]
// 2) Use Divide and Conquer: find the minimum bar in the current range
// 3) Calculate area using this minimum bar (Height x Width)
// 4) Recursively find the max area in the left and right halves
// 5) Return the maximum of the three results

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
        
        // Pad array to a power of 2 for the tree structure
        while ((n & (n - 1)) != 0)
        {
            Array.Resize(ref A, n + 1);
            A[n] = INF;
            n++;
        }
        tree = new int[2 * n];
        Build(); // Step 1: Pre-calculate the minimums
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

    // Returns the index of the minimum height between ql and qh in O(log N)
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

public class Solution
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
        if (l > r) return 0; // Base case: range is empty
        if (l == r) return heights[l]; // Base case: single bar

        // Step 2: Find the index of the minimum height in the current range
        int minIdx = st.Query(l, r);

        // Step 3 & 4: Divide the problem
        // Calculate the current area with heights[minIdx] as the height
        int currentArea = (r - l + 1) * heights[minIdx];

        // Step 5: Return the max between current, left side, and right side
        return Math.Max(
            currentArea,
            Math.Max(GetMaxArea(heights, l, minIdx - 1, st), // Left half
                    GetMaxArea(heights, minIdx + 1, r, st)) // Right half
        );
    }
}

// Monotonic Stack Approach
// The table is only traversed twice, which makes it incredibly fast
// 1) Find the nearest smaller element to the left for each bar
// 2) Find the nearest smaller element to the right for each bar
// 3) Calculate width using these boundaries: (right - left + 1)
// 4) Apply height x width and return the maximum area

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int[] leftMost = new int[n];   // To store index of the first smaller bar to the left
        int[] rightMost = new int[n];  // To store index of the first smaller bar to the right
        Stack<int> stack = new Stack<int>();

        // Step 1: Pre-calculate left boundaries
        for (int i = 0; i < n; i++)
        {
            // Default if no smaller element is found (imaginary wall at -1)
            leftMost[i] = -1; 
            
            // Pop from stack until we find a bar smaller than the current one
            while (stack.Count > 0 && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }
            // If stack is not empty, the top element is our "left wall"
            if (stack.Count > 0)
            {
                leftMost[i] = stack.Peek();
            }
            stack.Push(i); // Push current index for future bars
        }

        // Clear stack to reuse it for the right side
        stack.Clear();

        // Step 2: Pre-calculate right boundaries
        for (int i = n - 1; i >= 0; i--)
        {
            // Default if no smaller element is found (imaginary wall at n)
            rightMost[i] = n;
            
            // Pop until we find a bar smaller than the current one
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

        // Step 3 & 4: Calculate areas and find the maximum
        int maxArea = 0;
        for (int i = 0; i < n; i++)
        {
            // Adjust indices to get the actual boundaries of the rectangle
            int left = leftMost[i] + 1;
            int right = rightMost[i] - 1;
            
            // Area = height * width
            int currentArea = heights[i] * (right - left + 1);
            maxArea = Math.Max(maxArea, currentArea);
        }

        return maxArea;
    }
}

// Monotonic Stack Single Pass Approach
// 1) Iterate through each bar
// 2) If the current bar is shorter than the bar in the stack, 
//    it "limits" the previous bars. Pop and calculate their areas.
// 3) Keep track of the "start" index (how far the current height can extend backwards)
// 4) After the loop, calculate areas for the remaining bars in the stack
// 5) Return the maximum area found

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int maxArea = 0;
        // The stack stores pairs: [startIndex, height]
        Stack<int[]> stack = new Stack<int[]>(); 

        for (int i = 0; i < heights.Length; i++)
        { // Step 1: Iterate through each bar
            int start = i; 
            
            // Step 2: While the current bar is shorter than the top of the stack
            while (stack.Count > 0 && stack.Peek()[1] > heights[i])
            {
                int[] top = stack.Pop();
                int index = top[0];
                int height = top[1];
                
                // Calculate area: the popped bar's height * distance to current index
                maxArea = Math.Max(maxArea, height * (i - index));
                
                // Step 3: Important! The current shorter bar can extend backwards 
                // to where the popped bar started.
                start = index;
            }
            
            // Push the current height and its adjusted start index
            stack.Push(new int[] { start, heights[i] });
        }

        // Step 4: Process bars remaining in the stack
        // These bars extend all the way to the end of the histogram
        foreach (int[] pair in stack)
        {
            int index = pair[0];
            int height = pair[1];
            maxArea = Math.Max(maxArea, height * (heights.Length - index));
        }

        // Step 5: Return the result
        return maxArea;
    }
}

// Standard Monotonic Stack Approach
// 1) Iterate through the bars. If the bar is taller or the stack is empty, push its index.
// 2) If the bar is shorter, it means we've found the "right boundary" for the bars in the stack.
// 3) Pop and calculate the area for each bar that is taller than the current one.
// 4) After the main loop, process any remaining bars in the stack (they extend to the end).

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = 0;
        int index = 0;

        // Step 1: Main Loop through the bars
        while (index < heights.Length)
        {
            // If this bar is higher than or equal to the bar at the stack's top, push it
            if (stack.Count == 0 || heights[index] >= heights[stack.Peek()])
            {
                stack.Push(index++); // We stay in "increasing" mode
            }
            else
            {
                // Step 2 & 3: We found a shorter bar, so we Pop and calculate area
                int top = stack.Pop();
                
                // Width calculation: 
                // If stack is empty, it means heights[top] was the smallest so far (width = index)
                // Otherwise, width is the distance between the current index and the new top
                int area = heights[top] * (stack.Count == 0 ? index : index - stack.Peek() - 1);
                
                if (area > maxArea)
                {
                    maxArea = area;
                }
                // Note: index does NOT increment here, we re-check heights[index] against the new top
            }
        }

        // Step 4: Remaining bars in stack
        // These bars didn't find a "right boundary" shorter than them, 
        // so they extend to the very end of the histogram (index = heights.Length).
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

// Monotonic Increasing Stack (Single Pass with Sentinel)
// 1) Iterate through all bars + one virtual bar at the end (i == n)
// 2) If the current bar is shorter than the bar at the stack's top:
//    - The bar at the top has found its "right limit" (the current i)
//    - Its "left limit" is the element just below it in the stack
// 3) Calculate width: if stack is empty, it spans from index 0 to i
// 4) Update maxArea and push the current index

public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int n = heights.Length;
        int maxArea = 0;
        Stack<int> stack = new Stack<int>();

        // Step 1: Loop until n (inclusive) to trigger the final calculations
        for (int i = 0; i <= n; i++)
        {
            
            // Current height is 0 if we are at the virtual end bar (i == n)
            int currentHeight = (i == n) ? 0 : heights[i];

            // Step 2: While current bar is shorter, pop and calculate area
            while (stack.Count > 0 && heights[stack.Peek()] >= currentHeight)
            {
                
                // This is the height of the rectangle we are calculating
                int height = heights[stack.Pop()];
                
                // Step 3: Calculate the width
                // If stack is empty, the rectangle spans the entire distance to i
                // Otherwise, it spans from the new top of the stack to i
                int width = (stack.Count == 0) ? i : i - stack.Peek() - 1;
                
                // Step 4: Update maxArea
                maxArea = Math.Max(maxArea, height * width);
            }
            
            // Push the current index onto the stack
            stack.Push(i);
        }
        
        return maxArea;
    }
}
```


