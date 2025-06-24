/*
 * @lc app=leetcode.cn id=1023 lang=csharp
 *
 * [1023] 驼峰式匹配
 */

// @lc code=start
public class Solution1023
{
    public IList<bool> CamelMatch(string[] queries, string pattern)
    {
        List<bool> ans = new List<bool>();
        // for (int i = 0; i < queries.Length; i++)
        // {
        //     int l = 0;
        //     int r = 0;
        //     bool f = false;
        //     string check = queries[i];
        //     while (check.Length > l && r < pattern.Length)
        //     {
        //         if (check[l] == pattern[r])
        //             r++;
        //         else if (check[l] != pattern[r] && check[l] < 'a')
        //         {
        //             goto ContinueOuter;
        //         }
        //         l++;
        //     }
        //     if (r == pattern.Length)
        //     {
        //         bool flag = true;
        //         while (l < check.Length)
        //         {
        //             if (check[l] < 'a')//为大写
        //             {
        //                 flag = false;
        //                 break;
        //             }
        //             l++;
        //         }
        //         f = flag;
        //     }
        // ContinueOuter:;
        //     ans.Add(f);
        // }
        for (int i = 0; i < queries.Length; i++)
        {
            bool flag = true;
            int p = 0;
            foreach (char item in queries[i])
            {
                if (p < pattern.Length && item == pattern[p])
                {
                    p++;
                }
                else if (char.IsUpper(item))
                {
                    flag = false;
                    break;
                }
            }
            if (p < pattern.Length)
                flag = false;
            ans.Add(flag);
        }
        return ans;
    }
}
// @lc code=end

