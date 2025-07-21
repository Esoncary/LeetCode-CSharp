/*
 * @lc app=leetcode.cn id=838 lang=csharp
 *
 * [838] 推多米诺
 */

// @lc code=start
public class Solution838
{
    public string PushDominoes(string dominoes)
    {
        // int n = dominoes.Length;
        // char[] ans = new char[n];
        // Array.Fill(ans, '.');
        // for (int i = 0; i < n; i++)
        // {
        //     if (dominoes[i] == 'L')
        //     {
        //         int j = i;
        //         while (j > 0)
        //         {
        //             if (dominoes[--j] != '.')
        //                 break;
        //             ans[j] = 'L';
        //         }

        //     }
        //     else if (dominoes[i] == 'R')
        //     {
        //         int start = i;
        //         //找到R对应的L
        //         if (i < n && dominoes[i] != 'L')
        //             i++;
        //         //如果没找到了
        //         if (i == n)
        //         {
        //             for (; start < n; start++)
        //             {
        //                 ans[start] = 'R';
        //             }
        //         }
        //         else//如果找到了
        //         {
        //             int j = i;
        //             while (start != j)
        //             {
        //                 ans[start++] = 'R';
        //                 ans[j--] = 'L';
        //             }
        //         }
        //     }
        // }
        // return new string(ans);

        // 在头尾各加一个哨兵 L 和 R
        char[] s = ("L" + dominoes + "R").ToCharArray();
        int n = s.Length;
        int pre = 0; // 记录上一个非 '.' 的位置（L 或 R）

        for (int i = 1; i < n; i++)
        {
            if (s[i] == '.') continue;

            if (s[i] == s[pre])
            {
                // LL...L 或 RR...R：将 pre+1 .. i-1 全部填成 s[i]
                Array.Fill(s, s[i], pre + 1, i - pre - 1);
            }
            else if (s[pre] == 'R' && s[i] == 'L')
            {
                // R...L：两端对冲
                // 前半段（pre+1 .. mid-1）填 R
                int midRight = (pre + i + 1) / 2;
                Array.Fill(s, 'R', pre + 1, midRight - (pre + 1));
                // 后半段（mid+1 .. i-1）填 L
                int midLeft = (pre + i) / 2 + 1;
                Array.Fill(s, 'L', midLeft, i - midLeft);
                // 如果 (i - pre - 1) 是奇数，正中间一格保持 '.'
            }
            // 如果是 L...R，或其他组合，不需要填，保持原有的 '.'

            pre = i;
        }

        // 去掉前后哨兵，返回结果
        return new string(s, 1, n - 2);
    }
}
// @lc code=end

