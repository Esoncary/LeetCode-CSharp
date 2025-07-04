/*
 * @lc app=leetcode.cn id=2900 lang=csharp
 *
 * [2900] 最长相邻不相等子序列 I
 */

// @lc code=start
public class Solution2900
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups)
    {
        int n = groups.Length;
        List<string> ans = new List<string>();
        int last = 2;
        for (int i = 0; i < n; i++)
        {
            if (groups[i] != last)
            {
                last = groups[i];
                ans.Add(words[i]);
            }
        }
        return ans;
    }
}
// @lc code=end

