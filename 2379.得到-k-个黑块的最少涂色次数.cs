/*
 * @lc app=leetcode.cn id=2379 lang=csharp
 *
 * [2379] 得到 K 个黑块的最少涂色次数
 */

// @lc code=start
public class Solution2379
{
    public int MinimumRecolors(string blocks, int k)
    {
        int n = blocks.Length;
        int countBlack = 0;
        int minOper = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            //入
            countBlack = blocks[i] == 'B' ? countBlack + 1 : countBlack;
            if (i < k - 1)
                continue;
            //更新
            minOper = minOper > k - countBlack ? k - countBlack : minOper;
            //出
            countBlack = blocks[i - k + 1] == 'B' ? countBlack - 1 : countBlack;
        }
        return minOper;
    }
}
// @lc code=end

