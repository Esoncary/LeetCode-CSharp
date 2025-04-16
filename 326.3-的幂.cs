/*
 * @lc app=leetcode.cn id=326 lang=csharp
 *
 * [326] 3 的幂
 */

// @lc code=start
public class Solution326
{
    public bool IsPowerOfThree(int n)
    {
        return n > 0 && (1162261467 % n) == 0;
    }
}
// @lc code=end

