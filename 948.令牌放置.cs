/*
 * @lc app=leetcode.cn id=948 lang=csharp
 *
 * [948] 令牌放置
 */

// @lc code=start
public class Solution948
{
    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);
        int score = 0;
        int n = tokens.Length;
        int l = 0;
        int r = n - 1;
        int ans = 0;
        while (l <= r)
        {
            if (power >= tokens[l])
            {
                power -= tokens[l];
                score += 1;
                l += 1;
            }
            else if (power < tokens[l] && score > 0)
            {
                ans = Math.Max(ans, score);
                score--;
                power += tokens[r];
                r--;
            }
            else
            {
                break;
            }
        }
        return Math.Max(ans, score);
    }
}
// @lc code=end

