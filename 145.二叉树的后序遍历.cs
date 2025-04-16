/*
 * @lc app=leetcode.cn id=145 lang=csharp
 *
 * [145] 二叉树的后序遍历
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
public class Solution145
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        //递归
        List<int> list = new List<int>();
        // BehindOrder(root, list);
        // return list;

        //非递归
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode nowNode;
        if (root != null)
            stack.Push(root);
        while (stack.Count != 0)
        {
            nowNode = stack.Pop();
            list.Add(nowNode.val);
            if(nowNode.left != null)
                stack.Push(nowNode.left);
            if(nowNode.right != null)
                stack.Push(nowNode.right);
        }
        list.Reverse();
        return list;
    }
    // void BehindOrder(TreeNode root, List<int> list)
    // {
    //     if(root == null) return;
    //     BehindOrder(root.left, list);
    //     BehindOrder(root.right, list);
    //     list.Add(root.val);
    // }
}
// @lc code=end

