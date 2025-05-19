/*
 * @lc app=leetcode.cn id=2799 lang=csharp
 *
 * [2799] 统计完全子数组的数目
 */

// @lc code=start
public class Solution2799
{
    public int CountCompleteSubarrays(int[] nums)
    {
        int length = nums.Length;
        List<int> cnt = new List<int>();
        foreach (int item in nums)
        {
            if (!cnt.Contains(item))
            {
                cnt.Add(item);
            }
        }
        int count = cnt.Count;
        int left = 0;
        int ans = 0;
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
            }
            //
            while (dic.Count == count)
            {
                //update
                ans += length - right;
                //out
                dic[nums[left]]--;
                if (dic[nums[left]] == 0)
                {
                    dic.Remove(nums[left]);
                }

                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

