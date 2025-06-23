/*
 * @lc app=leetcode.cn id=1855 lang=csharp
 *
 * [1855] 下标对中的最大距离
 */

// @lc code=start
public class Solution1855
{
    public int MaxDistance(int[] nums1, int[] nums2)
    {
        // int i = 0;
        // int j = 0;
        // int n1 = nums1.Length;
        // int n2 = nums2.Length;
        // int sum = 0;
        // int ans = 0;
        // while (i < n1)
        // {
        //     while (j < n2)
        //     {
        //         if (i <= j && nums1[i] <= nums2[j])
        //         {
        //             sum = j - i;
        //             ans = Math.Max(sum, ans);
        //             j++;
        //         }
        //         else if (i > j)
        //         {
        //             j++;
        //         }
        //         else
        //         {
        //             break;
        //         }
        //     }
        //     i++;
        // }
        // return ans;
        int n1 = nums1.Length, n2 = nums2.Length;
        int ans = 0, j = 0;

        // i 从 0 到 n1-1，j 永远不回退，只往前走
        for (int i = 0; i < n1; i++)
        {
            // 尽可能让 j 右移，直到不满足 nums1[i] <= nums2[j]
            while (j < n2 && nums1[i] <= nums2[j])
            {
                j++;
            }
            // 此时 j 要么到头，要么是第一个使不等式失效的位置
            // j-1 是最后一个满足 nums1[i] <= nums2[j-1] 的下标
            // 且 i <= j-1 总是成立（因为 j 初始为 0，并且 i<=j 保持不变）
            ans = Math.Max(ans, j - 1 - i);
        }

        return ans;
    }
}
// @lc code=end

