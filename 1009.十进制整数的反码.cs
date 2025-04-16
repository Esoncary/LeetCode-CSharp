/*
 * @lc app=leetcode.cn id=1009 lang=csharp
 *
 * [1009] 十进制整数的反码
 */

// @lc code=start
public class Solution1009
{
    public int BitwiseComplement(int n)
    {
        if (n == 0)
            return 1;
        int ch = n;
        int count = 0;
        while (ch > 0)
        {
            ch /= 2;
            count++;
        }
        return (int)Math.Pow(2, count) - 1 - n;
    }
}
// @lc code=end

