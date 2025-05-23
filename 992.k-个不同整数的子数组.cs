/*
 * @lc app=leetcode.cn id=992 lang=csharp
 *
 * [992] K 个不同整数的子数组
 */

// @lc code=start
public class Solution992
{
    public int SubarraysWithKDistinct(int[] nums, int k)
    {
        return Ans(nums, k) - Ans(nums, k + 1);
    }
    public int Ans(int[] nums, int k)
    {
        int ans = 0;
        int left = 0;
        int length = nums.Length;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int right = 0; right < length; right++)
        {
            //in 
            int temp = nums[right];
            if (!dic.ContainsKey(temp))
                dic.Add(temp, 1);
            else
                dic[temp]++;
            while (dic.Count >= k)
            {
                ans += length - right;
                //out
                int x = nums[left];
                dic[x]--;
                if (dic[x] == 0)
                    dic.Remove(x);
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

