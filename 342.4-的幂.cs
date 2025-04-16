/*
 * @lc app=leetcode.cn id=342 lang=csharp
 *
 * [342] 4的幂
 */

// @lc code=start
public class Solution342
{
    public bool IsPowerOfFour(int n)
    {
        // while (n != 0 && n % 4 == 0)
        // {
        //     n /= 4;
        // }
        // return n == 1;
        return n > 0 && (n & (n - 1)) == 0 && (n & 0xaaaaaaaa) == 0;
    }
}
// @lc code=end

