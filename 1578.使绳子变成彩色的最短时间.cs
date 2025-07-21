public class Solution1578
{
    public int MinCost(string colors, int[] neededTime)
    {
        int n = colors.Length;
        int ans = 0;

        // 维护当前一段中所有 neededTime 的和 sum 和最大值 maxT
        int sum = neededTime[0], maxT = neededTime[0];

        for (int i = 1; i < n; i++)
        {
            if (colors[i] == colors[i - 1])
            {
                // 同一颜色段内累加，并更新最大值
                sum += neededTime[i];
                maxT = Math.Max(maxT, neededTime[i]);
            }
            else
            {
                // 颜色切换时：该段需要删除的最小代价 = sum - maxT
                ans += sum - maxT;
                // 重置到新段
                sum = neededTime[i];
                maxT = neededTime[i];
            }
        }

        // 别忘了最后一段也要结算一次
        ans += sum - maxT;
        return ans;
    }
}
