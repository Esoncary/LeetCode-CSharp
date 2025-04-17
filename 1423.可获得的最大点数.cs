/*
 * @lc app=leetcode.cn id=1423 lang=csharp
 *
 * [1423] 可获得的最大点数
 */

// @lc code=start
public class Solution1423
{
    public int MaxScore(int[] cardPoints, int k)
    {
        //每次拿走首/尾的牌，剩下的一定是连续的数组
        //拿走的牌的和最大 =》 剩下的拍最小
        int sum = 0;
        for (int i = 0; i < k; i++)
            sum += cardPoints[i];
        int total = sum;
        int min = sum;
        for (int i = cardPoints.Length - k; i < cardPoints.Length; i++)
        {
            total += cardPoints[i];
            sum += cardPoints[i] - cardPoints[i - cardPoints.Length + k];
            min = Math.Min(sum, min);
        }
        return total - min;
    }
}
// @lc code=end

