/*
 * @lc app=leetcode.cn id=2760 lang=csharp
 *
 * [2760] 最长奇偶子数组
 */

// @lc code=start
public class Solution2760
{
    public int LongestAlternatingSubarray(int[] nums, int threshold)
    {
        // int n = nums.Length;
        // int i = 0, j = -1;
        // int ans = 0;
        // int cnt = 1;
        // for (; i < n; i++)
        // {
        //     //先找到l
        //     while (j == -1)
        //     {
        //         if (i == n)//nums没有合适的
        //             return ans;
        //         if (nums[i] > threshold || nums[i] % 2 == 1)
        //             i++;
        //         else
        //         {
        //             j = i++;
        //             cnt = 1;
        //         }

        //     }

        //     if (i < n && nums[i] <= threshold && nums[i - 1] % 2 != nums[i] % 2)
        //     {
        //         cnt++;
        //         continue;
        //     }

        //     ans = Math.Max(cnt, ans);
        //     cnt = 1;
        //     j = -1;
        //     i--; // 回退到当前 i，使其被下次当作新起点处理
        // }
        // return ans = Math.Max(cnt, ans);

        int n = nums.Length;
        int ans = 0, i = 0;
        while (i < n)
        {
            if (nums[i] > threshold || nums[i] % 2 != 0)
            {
                i++; // 直接跳过
                continue;
            }
            int start = i; // 记录这一组的开始位置
            i++; // 开始位置已经满足要求，从下一个位置开始判断
            while (i < n && nums[i] <= threshold && nums[i] % 2 != nums[i - 1] % 2)
            {
                i++;
            }
            // 从 start 到 i-1 是满足题目要求的（并且无法再延长的）子数组
            ans = Math.Max(ans, i - start);
        }
        return ans;
    }
}
// @lc code=end

