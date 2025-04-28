/*
 * @lc app=leetcode.cn id=2958 lang=csharp
 *
 * [2958] 最多 K 个重复元素的最长子数组
 */

// @lc code=start
public class Solution2958
{
    public int MaxSubarrayLength(int[] nums, int k)
    {
        int length = nums.Length;
        int left = 0;
        int ans = 0;
        int count = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int right = 0; right < length; right++)
        {
            //in
            int x = nums[right];
            count++;
            if (!dic.ContainsKey(x))
                dic.Add(x, 0);
            dic[x]++;
            //out
            while (dic[x] > k)
            {
                int y = nums[left];
                dic[y]--;
                left++;
                count--;
            }
            //update
            ans = Math.Max(ans, count);
        }
        return ans;
    }
}
// @lc code=end

