/*
 * @lc app=leetcode.cn id=3258 lang=csharp
 *
 * [3258] 统计满足 K 约束的子字符串数量 I
 */

// @lc code=start
public class Solution3258
{
    public int CountKConstraintSubstrings(string s, int k)
    {
        char[] arr = s.ToCharArray();
        int[] cnt = new int[2];
        int ans = 0;
        int left = 0;
        int length = s.Length;
        for (int right = 0; right < length; right++)
        {
            //in
            cnt[arr[right] - '0']++;
            //out
            while (cnt[0] > k && cnt[1] > k)
            {
                cnt[arr[left] - '0']--;
                left++;
            }

            //update
            ans += right - left + 1;
        }
        return ans;
    }
}
// @lc code=end

