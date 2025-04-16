/*
 * @lc app=leetcode.cn id=100 lang=csharp
 *
 * [100] 相同的树
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
public class Solution100
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        //深度优先
        // if (p == null && q == null)
        // {
        //     return true;
        // }
        // else if (p == null || q == null)
        // {
        //     return false;
        // }
        // else if (p.val != q.val)
        // {
        //     return false;
        // }
        // else
        // {
        //     return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        // }

        //广度优先
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;

        // 使用两个队列进行层序比较
        Queue<TreeNode> queue1 = new Queue<TreeNode>();
        Queue<TreeNode> queue2 = new Queue<TreeNode>();
        queue1.Enqueue(p);
        queue2.Enqueue(q);

        while (queue1.Count > 0 && queue2.Count > 0)
        {
            TreeNode node1 = queue1.Dequeue();
            TreeNode node2 = queue2.Dequeue();

            // 比较当前节点值
            if (node1.val != node2.val) return false;

            // 获取子节点引用
            TreeNode left1 = node1.left, right1 = node1.right;
            TreeNode left2 = node2.left, right2 = node2.right;

            // 使用异或判断子节点结构差异
            if ((left1 == null) ^ (left2 == null)) return false;
            if ((right1 == null) ^ (right2 == null)) return false;

            // 将非空子节点入队
            if (left1 != null) queue1.Enqueue(left1);
            if (right1 != null) queue1.Enqueue(right1);
            if (left2 != null) queue2.Enqueue(left2);
            if (right2 != null) queue2.Enqueue(right2);
        }

        // 最终检查队列是否同时为空
        return queue1.Count == 0 && queue2.Count == 0;

    }
}
// @lc code=end

