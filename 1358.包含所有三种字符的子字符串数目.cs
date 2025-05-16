/*
 * @lc app=leetcode.cn id=1358 lang=csharp
 *
 * [1358] 包含所有三种字符的子字符串数目
 */

// @lc code=start
public class Solution1358
{
    public int NumberOfSubstrings(string s)
    {
        int ans = 0;
        int left = 0;
        int length = s.Length;
        int[] cnt = new int[3];
        for (int right = 0; right < length; right++)
        {
            //in
            cnt[s[right] - 'a']++;
            while (cnt[0] >= 1 && cnt[1] >= 1 && cnt[2] >= 1)
            {
                // 计算以当前right为结尾的有效子串数量
                ans += s.Length - right;
                // 缩小窗口
                cnt[s[left] - 'a']--;
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

