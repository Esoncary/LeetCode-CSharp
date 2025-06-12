/*
 * @lc app=leetcode.cn id=2570 lang=csharp
 *
 * [2570] 合并两个二维数组 - 求和法
 */

// @lc code=start
public class Solution2570
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        List<int[]> ans = new List<int[]>();
        int i = 0;
        int j = 0;
        int n_1 = nums1.Length;
        int n_2 = nums2.Length;
        while (i < n_1 && j < n_2)
        {
            if (nums1[i][0] > nums2[j][0])
            {
                ans.Add(nums2[j]);
                j++;
            }
            else if (nums1[i][0] < nums2[j][0])
            {
                ans.Add(nums1[i]);
                i++;
            }
            else
            {
                ans.Add(new int[] { nums1[i][0], nums1[i][1] + nums2[j][1] });
                i++;
                j++;
            }
        }
        if (i == n_1)
        {
            while (j < n_2)
            {
                ans.Add(nums2[j++]);
            }
        }
        if (j == n_2)
        {
            while (i < n_1)
            {
                ans.Add(nums1[i++]);
            }
        }
        return ans.ToArray();
    }
}
// @lc code=end

