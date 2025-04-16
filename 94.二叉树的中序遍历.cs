/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution94
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        //递归
        var res = new List<int>();
        InorderHelper(root, res);
        return res;


    }
    void InorderHelper(TreeNode root, IList<int> res)
    {
        if (root == null) return;
        InorderHelper(root.left, res);
        res.Add(root.val);
        InorderHelper(root.right, res);
    }
}
// @lc code=end

