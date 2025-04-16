/*
 * @lc app=leetcode.cn id=405 lang=csharp
 *
 * [405] 数字转换为十六进制数
 */

// @lc code=start
public class Solution405
{
    public string ToHex(int num)
    {
        return Convert.ToString(num, 16).ToString();
    }
}
// @lc code=end

