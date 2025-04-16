/*
 * @lc app=leetcode.cn id=111 lang=csharp
 *
 * [111] 二叉树的最小深度
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
public class Solution111 {
    public int MinDepth(TreeNode root) {
        //递归
        // if(root == null) return 0;
        // if( root.left == null ) return MinDepth(root.right) + 1;
        // if( root.right == null ) return MinDepth(root.left) + 1;
        // return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;

        //递归 比较左右子树的大小 取小 不断递归就行了
        if( root == null ) return 0;
        if( root.left == null && root.right == null ) return 1;
        int minDepth = int.MaxValue;
        if( root.left != null)
            minDepth = Math.Min(minDepth, MinDepth(root.left));
        if( root.right != null)
            minDepth = Math.Min(minDepth, MinDepth(root.right));
        return minDepth + 1;
    }
}
// @lc code=end

