/*
 * @lc app=leetcode.cn id=1652 lang=csharp
 *
 * [1652] 拆炸弹
 */

// @lc code=start
public class Solution1652_e
{
    public int[] Decrypt(int[] code, int k)
    {
        int n = code.Length;
        int[] ans = new int[n];
        int r = k > 0 ? k + 1 : n; // 第一个窗口的右开端点
        k = Math.Abs(k);
        int s = 0;
        for (int i = r - k; i < r; i++)
        {
            s += code[i]; // 计算 ans[0]
        }
        for (int i = 0; i < n; i++)
        {
            ans[i] = s;
            s += code[r % n] - code[(r - k) % n];
            r++;
        }
        return ans;
    }
}
// @lc code=end

