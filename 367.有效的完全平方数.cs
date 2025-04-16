/*
 * @lc app=leetcode.cn id=367 lang=csharp
 *
 * [367] 有效的完全平方数
 */

// @lc code=start
public class Solution367
{
    public bool IsPerfectSquare(int num)
    {
        int num1 = 1;
        while (num > 0)
        {
            num -= num1;
            num1 += 2;
        }
        return num == 0;
    }
}
// @lc code=end

