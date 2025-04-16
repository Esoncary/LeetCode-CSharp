/*
 * @lc app=leetcode.cn id=226 lang=csharp
 *
 * [226] 翻转二叉树
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
public class Solution226
{
    public TreeNode InvertTree(TreeNode root)
    {
        TreeNode temp;
        if (root == null) return root;

        root.left = InvertTree(root.left);
        root.right = InvertTree(root.right);

        temp = root.left;
        root.left = root.right;
        root.right = temp;
        return root;
    }
}
// @lc code=end

