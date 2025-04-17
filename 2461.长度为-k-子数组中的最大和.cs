/*
 * @lc app=leetcode.cn id=2461 lang=csharp
 *
 * [2461] 长度为 K 子数组中的最大和
 */

// @lc code=start
public class Solution2461
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        long sum = 0;
        long max = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            //入
            sum += nums[i];
            if (!dic.ContainsKey(nums[i]))
                dic.Add(nums[i], 1);
            else
                dic[nums[i]]++;

            if (i < k - 1)
                continue;

            //更新
            if (dic.Count >= k)
            {
                max = Math.Max(sum, max);
            }
            //出
            sum -= nums[i - k + 1];
            dic[nums[i - k + 1]]--;
            if (dic[nums[i - k + 1]] == 0)
                dic.Remove(nums[i - k + 1]);
        }
        return max;
    }
}
// @lc code=end

