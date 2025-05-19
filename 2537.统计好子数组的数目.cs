/*
 * @lc app=leetcode.cn id=2537 lang=csharp
 *
 * [2537] 统计好子数组的数目
 */

// @lc code=start
public class Solution2537
{
    public long CountGood(int[] nums, int k)
    {
        int left = 0;
        long cnt = 0;
        long ans = 0;
        int length = nums.Length;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int right = 0; right < length; right++)
        {
            //in
            if (!dic.ContainsKey(nums[right]))
            {
                dic.Add(nums[right], 1);
            }
            else
            {
                dic[nums[right]]++;
                cnt += dic[nums[right]] - 1;
            }


            while (cnt >= k)
            {
                //update
                ans += length - right;
                //out

                if (dic[nums[left]] >= 2)
                    cnt -= dic[nums[left]] - 1;
                dic[nums[left]]--;
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

