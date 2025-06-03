/*
 * @lc app=leetcode.cn id=611 lang=csharp
 *
 * [611] 有效三角形的个数
 */

// @lc code=start
public class Solution611
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);
        int n = nums.Length;
        int cnt = 0;
        for (int i = n - 1; i >= 2; i--)
        {
            int a = nums[i];//长边
            int l = 0;
            int r = i - 1;
            //双指针
            while (l < r)
            {
                if (nums[l] + nums[r] <= a)
                {
                    l++;
                }
                else
                {
                    cnt += r - l;
                    r--;
                }
            }
        }
        return cnt;
    }
}
// @lc code=end

