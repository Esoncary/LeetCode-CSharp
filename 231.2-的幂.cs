/*
 * @lc app=leetcode.cn id=231 lang=csharp
 *
 * [231] 2 的幂
 */

// @lc code=start
public class Solution231
{
    public bool IsPowerOfTwo(int n)
    {
        return n > 0 && (n & (n - 1)) == 0;
    }
}
// @lc code=end

