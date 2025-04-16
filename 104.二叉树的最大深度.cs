/*
 * @lc app=leetcode.cn id=104 lang=csharp
 *
 * [104] 二叉树的最大深度
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
public class Solution104 {
    public int MaxDepth(TreeNode root) {
        //深度优先
        // if(root == null) return 0;
        // return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;

        //广度优先
        int depth = 0;
        if(root == null ) return 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            depth++;
            int size = q.Count;
            for(int i = 0; i < size; i++)
            {
                TreeNode tn = q.Dequeue();
                if(tn.left != null) q.Enqueue(tn.left);
                if(tn.right != null) q.Enqueue(tn.right);
            } 
        }
        return depth;
    }
}
// @lc code=end

