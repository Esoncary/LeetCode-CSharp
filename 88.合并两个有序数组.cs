/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution88
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int index1 = m - 1, index2 = n - 1, index = m + n - 1;
        while (index1 >= 0 && index2 >= 0)
        {
            if (nums1[index1] >= nums2[index2])
            {
                nums1[index] = nums1[index1];
                index1--;
                index--;
            }
            else
            {
                nums1[index] = nums2[index2];
                index2--;
                index--;
            }
        }
        if (index1 >= 0) for (int i = index1; i >= 0; i--) nums1[index--] = nums1[index1--];
        if (index2 >= 0) for (int i = index2; i >= 0; i--) nums1[index--] = nums2[index2--];

    }
}
// @lc code=end

