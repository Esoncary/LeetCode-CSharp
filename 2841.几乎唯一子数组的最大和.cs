/*
 * @lc app=leetcode.cn id=2841 lang=csharp
 *
 * [2841] 几乎唯一子数组的最大和
 */

// @lc code=start
public class Solution2841
{
    public long MaxSum(IList<int> nums, int m, int k)
    {
        long sum = 0;
        long max = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Count; i++)
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
            if (dic.Count >= m)
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

    //test git
}
// @lc code=end

