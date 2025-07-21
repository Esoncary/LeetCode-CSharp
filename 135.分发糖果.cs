/*
 * @lc app=leetcode.cn id=135 lang=csharp
 *
 * [135] 分发糖果
 */

// @lc code=start
public class Solution135
{
    public int Candy(int[] ratings)
    {
        int n = ratings.Length;
        int ans = n;//每个人发一颗

        for (int i = 0; i < n; i++)
        {
            int start = i > 0 && ratings[i - 1] < ratings[i] ? i - 1 : i;

            //找递增
            while (i + 1 < n && ratings[i] < ratings[i + 1])
            {
                i++;
            }

            int top = i;

            //找递减
            while (i + 1 < n && ratings[i] > ratings[i + 1])
            {
                i++;
            }
            int inc = top - start;
            int dec = i - top;
            ans += (inc * (inc - 1) + dec * (dec - 1)) / 2 + Math.Max(inc, dec);

        }
        return ans;
    }
}
// @lc code=end

