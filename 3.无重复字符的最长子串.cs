/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start
public class Solution3
{
    public int LengthOfLongestSubstring(string s)
    {
        char[] chars = s.ToCharArray();
        int n = s.Length;
        int[] arr = new int[128];
        int left = 0;
        int ans = 0;
        for (int right = 0; right < n; right++)
        {
            //in
            arr[chars[right]]++;
            //out
            while (arr[chars[right]] > 1)
            {
                arr[chars[left]]--;
                left++;
            }
            //update
            ans = Math.Max(ans, right - left + 1);
        }
        return ans;
    }
}
// @lc code=end

