/*
 * @lc app=leetcode.cn id=101 lang=csharp
 *
 * [101] 对称二叉树
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
public class Solution101 {
    public bool IsSymmetric(TreeNode root) {
        return AreSymmetric(root.left, root.right);
    }
    public bool AreSymmetric(TreeNode p, TreeNode q)
    {
        if(p == null && q ==null)
        {
            return true;
        }
        else if(p == null || q ==null)
        {
            return false;
        }
        else if(p.val != q.val)
        {
            return false;
        }
        else
        {
            return AreSymmetric(p.left, q.right) && AreSymmetric(p.right, q.left);
        }

    }
}
// @lc code=end

