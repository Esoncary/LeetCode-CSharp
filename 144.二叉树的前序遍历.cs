/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
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
public class Solution144 {
    public IList<int> PreorderTraversal(TreeNode root) {
        //递归
        List<int> list = new List<int>();
        // Preorder(root, list);
        // return list;

        //非递归
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(root != null)
            stack.Push(root);
        TreeNode nowNode;
        while(stack.Count != 0)
        {
            nowNode = stack.Pop();
            list.Add(nowNode.val);
            if(nowNode.right != null)
                stack.Push(nowNode.right);
            if(nowNode.left != null)
                stack.Push(nowNode.left);
        }
        return list;
    }
    // void Preorder(TreeNode root, List<int> list)
    // {
    //     if( root == null ) return;
    //     list.Add(root.val);
    //     Preorder(root.left, list);
    //     Preorder(root.right, list);
    // }
}
// @lc code=end

