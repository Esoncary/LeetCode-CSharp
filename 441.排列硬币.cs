/*
 * @lc app=leetcode.cn id=441 lang=csharp
 *
 * [441] 排列硬币
 */

// @lc code=start
public class Solution441
{
    public int ArrangeCoins(int n)
    {
        int ans = 0;
        int i = 1;
        while (true)
        {
            n -= i;
            if (n < 0)
                return ans;
            ans++;
            i++;
        }
    }
}
// @lc code=end

