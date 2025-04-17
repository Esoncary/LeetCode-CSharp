/*
 * @lc app=leetcode.cn id=1052 lang=csharp
 *
 * [1052] 爱生气的书店老板
 */

// @lc code=start
public class Solution1052
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        //找minutes内的时间，顾客损失最多的
        int ans = 0;
        int windowLoss = 0;
        int maxLoss = int.MinValue;
        int n = customers.Length;
        for (int i = 0; i < n; i++)
        {
            //in
            if (grumpy[i] == 0)
                ans += customers[i];// 1 1 2 
            else
                windowLoss += customers[i];// 0 0 0 2

            if (i < minutes - 1)
                continue;
            //update
            maxLoss = Math.Max(maxLoss, windowLoss);//0 2
            //out
            if (grumpy[i - minutes + 1] == 1)
                windowLoss -= customers[i - minutes + 1];
        }
        return maxLoss + ans;
    }
}
// @lc code=end

