using System;
namespace CompetitiveProgramming.LeetCode.ConstructQuadTree
{
    /*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node() {
        val = false;
        isLeaf = false;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val, bool _isLeaf) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = null;
        topRight = null;
        bottomLeft = null;
        bottomRight = null;
    }
    
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
    }
}
*/

//public class Solution
//{
//         public Node Construct(int[][] grid)
//             => GetNode(grid, grid.Length, 0, 0);

//         private Node GetNode(int[][] grid, int size, int i, int k)
//         {
//             if (size == 1 || AreSame(grid, size, i, k))
//                 return new Node(grid[i][k] == 1, true);

//             return new Node(true, false,
//                 GetNode(grid, size / 2, i, k),
//                 GetNode(grid, size / 2, i, k + (size / 2)),
//                 GetNode(grid, size / 2, i + (size / 2), k),
//                 GetNode(grid, size / 2, i + (size / 2), k + (size / 2)));
//         }

//         private bool AreSame(int[][] grid, int size, int i, int k)
//         {
//             for (int ii = i; ii < i + size; ii++)
//                 for (int kk = k; kk < k + size; kk++)
//                     if (grid[ii][kk] != grid[i][k])
//                         return false;

//             return true;
//         }
//     }
}

