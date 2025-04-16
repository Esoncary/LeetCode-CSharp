/*
 * @lc app=leetcode.cn id=222 lang=csharp
 *
 * [222] 完全二叉树的节点个数
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
public class Solution222
{
    public int CountNodes(TreeNode root)
    {
        //遍历
        // Queue<TreeNode> queue = new Queue<TreeNode>();
        // TreeNode temp;
        // int count = 0;
        // if (root != null)
        //     queue.Enqueue(root);
        // while (queue.Count > 0)
        // {
        //     temp = queue.Dequeue();
        //     count++;
        //     if (temp.left != null)
        //         queue.Enqueue(temp.left);
        //     if (temp.right != null)
        //         queue.Enqueue(temp.right);
        // }
        // return count;

        //递归
        //return root == null ? 0 : (1 + CountNodes(root.left) + CountNodes(root.right));

        //利用完全二叉树的性质，二分查找
        if (root == null)
        {
            return 0;
        }
        int height = 0;
        TreeNode node = root;
        while (node.left != null)
        {
            height++;
            node = node.left;
        }
        int low = 1 << height;
        int max = (1 << (height + 1)) - 1;
        while (low < max)
        {
            int mid = (max - low + 1) / 2 + low;
            if (exists(root, height, mid))
            {
                low = mid;
            }
            else
            {
                max = mid - 1;
            }
        }
        return low;
    }
    public bool exists(TreeNode root, int level, int k)
    {
        //在完全二叉树中，编号从1开始，根节点到叶节点的路径可以由叶节点编号的2进制， 去掉最高位的1，得到，0代表左移，1代表右移
        //因为左节点的2进制是父节点的两倍，右节点的2进制是父节点的2倍+1
        //举个例子[1, 2, 3, 4, 5, 6]
        //求1到6的路径     6的2进制是110，  先去掉最高位的1 得到10，即先右移在左移

        //本方法是如此，用掩码bits来得到一个次高位是1 其余都是0的二进制，通过与叶节点2进制&来得到每一步的位移信息
        int bits = 1 << (level - 1);//是一个掩码
        TreeNode node = root;
        while (node != null && bits > 0)
        {
            if ((bits & k) == 0)
            {
                node = node.left;
            }
            else
            {
                node = node.right;
            }
            bits >>= 1;
        }
        return node != null;
    }
}
// @lc code=end

