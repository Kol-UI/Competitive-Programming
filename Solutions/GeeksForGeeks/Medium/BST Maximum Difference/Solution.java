
/*
    You are given a Binary Search Tree and a target value.
    You must find the maximum difference between the sum of node data from root to target and from target to a child leaf node (target exclusive).
    Initially, you are at the root node.
    Note: If the target node is not present in the tree then return -1.

    Example 1:
    Target = 20
    Output: 10
    Explanation: From root to target the sum of node data is 25 and from target to the children leaf nodes the sums of the node data are 15 and 25. So, the maximum difference will be (25-15) = 10.
    
    Example 2:
    Target = 50
    Output: -1
    Explanation: The target node is not present in the tree.

    Your Task:
    You don't need to read input or print anything.
    Your task is to complete the function maxDifferenceBST() which takes BST(you are given the root node of the BST )
    and target as input, and returns an interger value as the required answer.
    If the target is not present in the BST then return -1.


//User function Template for Java

class Solution
{
    static int res;
    public static int maxDifferenceBST(Node root,int target)
    {
        int sum=0;
        Node  curr=root;
        while(curr!=null)
        {
            if(curr.data == target)
            {
                break;
            }
            else if(curr.data < target)
            {
                sum += curr.data;
                curr = curr.right;
            }
            else
            {
                sum += curr.data;
                curr = curr.left;
            }
        }
        if(curr == null)
        {
            return -1;
        }

       else
       {
           
            if(curr.left == null && curr.right == null)
            {
                return sum;
            }
            res = Integer.MIN_VALUE;
            if(curr.left != null)
            {
                solve(curr.left, 0, sum);
            }
            
            if(curr.right != null)
            {
                solve(curr.right, 0, sum);
            }
       }
       return res;
    }
    
    static void solve(Node root, int path_sum , int sum)
    {
        
        if(root == null)
        {
            return;
        }

        if(root.left == null && root.right == null)
        {
            res = Math.max(res, sum - (path_sum + root.data));
            return;
        }
        
        solve(root.left, path_sum + root.data, sum);
        solve(root.right, path_sum + root.data, sum);
    }
}

*/