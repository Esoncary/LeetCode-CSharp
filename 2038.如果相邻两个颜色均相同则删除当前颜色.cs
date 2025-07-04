/*
 * @lc app=leetcode.cn id=2038 lang=csharp
 *
 * [2038] 如果相邻两个颜色均相同则删除当前颜色
 */

// @lc code=start
public class Solution2038
{
    public bool WinnerOfGame(string colors)
    {
        // int cnt_a = 0;
        // int cnt_b = 0;
        // int ans_a = 0;
        // int ans_b = 0;
        // int n = colors.Length;
        // int i = 0;
        // while (i < n)
        // {
        //     while (i < n && colors[i] == 'A')
        //     {
        //         cnt_a++;
        //         ans_b += cnt_b >= 3 ? cnt_b - 2 : 0;
        //         cnt_b = 0;
        //         i++;
        //     }

        //     while (i < n && colors[i] == 'B')
        //     {
        //         cnt_b++;
        //         ans_a += cnt_a >= 3 ? cnt_a - 2 : 0;
        //         cnt_a = 0;
        //         i++;
        //     }

        // }
        // ans_b += cnt_b >= 3 ? cnt_b - 2 : 0;
        // ans_a += cnt_a >= 3 ? cnt_a - 2 : 0;
        // return ans_a > ans_b;

        int[] freq = { 0, 0 };
        char cur = 'C';
        int cnt = 0;
        foreach (char c in colors)
        {
            if (c != cur)
            {
                cur = c;
                cnt = 1;
            }
            else
            {
                cnt += 1;
                if (cnt >= 3)
                {
                    freq[cur - 'A'] += 1;
                }
            }
        }
        return freq[0] > freq[1];
    }
}
// @lc code=end

