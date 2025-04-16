/*
 * @lc app=leetcode.cn id=404 lang=csharp
 *
 * [404] 左叶子之和
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
public class Solution404
{
    public int SumOfLeftLeaves(TreeNode root)
    {
        int sum = 0;
        BackLeaves(root, ref sum, false);
        return sum;
    }
    //递归
    public void BackLeaves(TreeNode root, ref int sum, bool isLeft)
    {
        if (root == null) return;
        if (isLeft && root.left == null && root.right == null)
            sum += root.val;
        BackLeaves(root.left, ref sum, true);
        BackLeaves(root.right, ref sum, false);

    }
}
// @lc code=end

