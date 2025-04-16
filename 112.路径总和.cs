/*
 * @lc app=leetcode.cn id=112 lang=csharp
 *
 * [112] 路径总和
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution112
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return DFS(root, targetSum, 0) >= 1 ? true : false;
    }
    //DFS
    public int DFS(TreeNode root, int targetSum, int sum)
    {
        //没有节点
        if (root == null) return 0;
        //记录当前节点的值
        sum += root.val;
        //用count作为标识
        int count = 0;
        if(root.left == null && root.right == null && sum == targetSum)
        {
            count = 1;
        }
        count += DFS(root.left, targetSum, sum );
        count += DFS(root.right, targetSum, sum );

        return count;
    }
}
// @lc code=end

