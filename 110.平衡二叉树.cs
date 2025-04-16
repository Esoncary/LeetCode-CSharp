/*
 * @lc app=leetcode.cn id=110 lang=csharp
 *
 * [110] 平衡二叉树
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
public class Solution110
{
    public bool IsBalanced(TreeNode root)
    {
        return DFS(root) != -1;
    }

    // 深度优先搜索
    private int DFS(TreeNode root)
    {
        if (root == null) return 0;

        int leftDepth = DFS(root.left);
        if (leftDepth == -1) return -1; // 直接返回，不再递归

        int rightDepth = DFS(root.right);
        if (rightDepth == -1) return -1; // 直接返回，不再递归

        if (Math.Abs(leftDepth - rightDepth) > 1) return -1; // 发现不平衡，返回 -1

        return Math.Max(leftDepth, rightDepth) + 1;
    }
}
// @lc code=end

