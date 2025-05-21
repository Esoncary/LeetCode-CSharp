/*
 * @lc app=leetcode.cn id=1248 lang=csharp
 *
 * [1248] 统计「优美子数组」
 */

// @lc code=start
public class Solution1248
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        return Ans(nums, k - 1) - Ans(nums, k);
    }
    public int Ans(int[] nums, int k)
    {
        int length = nums.Length;
        int left = 0;
        int asn = 0;
        int cnt = 0;
        for (int right = 0; right < length; right++)
        {
            //in
            if (nums[right] % 2 == 1)
                cnt++;
            while (cnt > k)
            {
                asn += length - right;
                if (nums[left] % 2 == 1)
                    cnt--;
                left++;
            }
        }
        return asn;
    }
}
// @lc code=end

