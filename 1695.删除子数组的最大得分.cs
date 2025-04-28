/*
 * @lc app=leetcode.cn id=1695 lang=csharp
 *
 * [1695] 删除子数组的最大得分
 */

// @lc code=start
public class Solution1695
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        int length = nums.Length;
        int ans = 0;
        int sum = 0;
        int left = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int right = 0; right < length; right++)
        {
            //in
            sum += nums[right];
            if (!dic.ContainsKey(nums[right]))
                dic.Add(nums[right], 0);
            dic[nums[right]]++;
            //out
            while (dic[nums[right]] >= 2)
            {
                dic[nums[left]]--;
                // if (dic[nums[right]] == 0)
                //     dic.Remove(nums[right]);
                sum -= nums[left];
                left++;
            }
            //update
            ans = Math.Max(sum, ans);
        }
        return ans;
    }
}
// @lc code=end

