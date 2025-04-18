/*
 * @lc app=leetcode.cn id=3439 lang=csharp
 *
 * [3439] 重新安排会议得到最多空余时间 I
 */

// @lc code=start
public class Solution3439
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int n = startTime.Length;
        int sum = 0;
        int max = 0;
        for (int i = 0; i <= n; i++)
        {
            //in
            sum += get(i, eventTime, startTime, endTime);
            if (i < k)
                continue;
            //update
            max = Math.Max(max, sum);
            //out
            sum -= get(i - k, eventTime, startTime, endTime);
        }
        return max;
    }
    public int get(int i, int eventTime, int[] start, int[] end)
    {
        if (i == 0)
            return start[0];
        if (i == end.Length)
            return eventTime - end[end.Length - 1];
        return start[i] - end[i - 1];
    }
}
// @lc code=end

