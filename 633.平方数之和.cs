/*
 * @lc app=leetcode.cn id=633 lang=csharp
 *
 * [633] 平方数之和
 */

// @lc code=start
public class Solution633
{
    public bool JudgeSquareSum(int c)
    {
        int a = 0;
        int b = (int)Math.Sqrt(c);
        long sum = 0;
        while (a <= b)
        {
            if (a * a == c - b * b)
            { // 避免溢出
                return true;
            }
            if (a * a < c - b * b)
            {
                a++;
            }
            else
            {
                b--;
            }
        }
        return false;
    }
}
// @lc code=end

