/*
 * @lc app=leetcode.cn id=3347 lang=csharp
 *
 * [3347] 执行操作后元素的最高频率 II
 */

// @lc code=start
public class Solution3347
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        Array.Sort(nums);

        int n = nums.Length;
        int ans = 0;
        int cnt = 0;
        int left = 0;
        int right = 0;
        //拉到现有的元素值
        for (int i = 0; i < n; i++)
        {
            int x = nums[i];
            cnt++;
            if (i < n - 1 && x == nums[i + 1])
                continue;
            while (nums[left] < x - k)
                left++;
            while (right < n && nums[right] <= x + k)
                right++;
            ans = Math.Max(ans, Math.Min(numOperations + cnt, right - left));
            cnt = 0;
        }
        //剪枝
        if (ans >= numOperations)
        {
            return ans;
        }
        //拉到中间元素
        left = 0;
        for (right = 0; right < n; right++)
        {
            int x = nums[right];
            while (nums[left] < x - 2 * k)
                left++;
            ans = Math.Max(ans, Math.Min(numOperations, right - left + 1));
        }
        return ans;
    }
}
// @lc code=end

