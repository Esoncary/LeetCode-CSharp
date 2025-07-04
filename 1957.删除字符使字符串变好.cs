/*
 * @lc app=leetcode.cn id=1957 lang=csharp
 *
 * [1957] 删除字符使字符串变好
 */

// @lc code=start
public class Solution1957
{
    public string MakeFancyString(string s)
    {
        int n = s.Length;
        char[] arr = s.ToCharArray();
        char[] ans = new char[n];
        int cnt = 1;
        int j = 1;
        ans[0] = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] == arr[i - 1])
                cnt++;
            else
                cnt = 1;
            if (cnt >= 3)
                continue;
            ans[j++] = arr[i];
        }

        return new string(ans, 0, j);
    }
}
// @lc code=end

