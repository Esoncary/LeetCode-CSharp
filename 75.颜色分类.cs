/*
 * @lc app=leetcode.cn id=75 lang=csharp
 *
 * [75] 颜色分类
 */

// @lc code=start
public class Solution75
{
    public void SortColors(int[] nums)
    {
        //暴力
        // Array.Sort(nums);
        int n = nums.Length;
        int cnt_0 = 0;
        int cnt_1 = 0;
        int cnt_2 = 0;
        foreach (int item in nums)
        {
            if (item == 0)
            {
                cnt_0++;
            }
            else if (item == 1)
            {
                cnt_1++;
            }
            else
            {
                cnt_2++;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (i < cnt_0)
            {
                nums[i] = 0;
            }
            else if (i < cnt_0 + cnt_1)
            {
                nums[i] = 1;
            }
            else
            {
                nums[i] = 2;
            }
        }
    }
}
// @lc code=end

