/*
 * @lc app=leetcode.cn id=1498 lang=csharp
 *
 * [1498] 满足条件的子序列数目
 */

// @lc code=start
public class Solution1498
{
    public int NumSubseq(int[] nums, int target)
    {
        const int MOD = 1000000007;
        Array.Sort(nums);
        int n = nums.Length;
        int l = 0;
        int r = n - 1;
        long ans = 0;
        // 预先算好 2^i % MOD，i 最多到 n-1
        int[] pow2 = new int[n];
        pow2[0] = 1;
        for (int i = 1; i < n; i++)
        {
            // 相当于 pow2[i] = (pow2[i-1] * 2) % MOD
            pow2[i] = (pow2[i - 1] << 1) % MOD;
        }
        while (l <= r)
        {
            if (nums[l] + nums[r] <= target)
            {
                // 直接取 pow2[r-l]，不会有浮点误差
                ans = (ans + pow2[r - l]) % MOD;
                l++;
            }
            else
            {
                r--;
            }
        }
        return (int)ans % MOD;
    }
}
// @lc code=end

