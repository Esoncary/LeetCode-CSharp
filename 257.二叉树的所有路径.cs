/*
 * @lc app=leetcode.cn id=257 lang=csharp
 *
 * [257] 二叉树的所有路径
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
public class Solution257
{
    List<string> list = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        GetRoute(root, "");
        return list;
    }
    public void GetRoute(TreeNode root, string s)
    {
        s += root.val;
        if (root.left != null)
            GetRoute(root.left, s + "->");
        if (root.right != null)
            GetRoute(root.right, s + "->");
        if (root.left == null && root.right == null)
            list.Add(s);
    }
}
// @lc code=end

