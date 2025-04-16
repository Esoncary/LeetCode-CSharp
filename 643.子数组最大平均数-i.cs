/*
 * @lc app=leetcode.cn id=643 lang=csharp
 *
 * [643] 子数组最大平均数 I
 */

// @lc code=start
public class Solution643
{
    public double FindMaxAverage(int[] nums, int k)
    {
        // double sum = 0;

        // //滑动窗口
        // //计算前i个的和
        // for (int i = 0; i < k; i++)
        // {
        //     sum += nums[i];
        // }
        // double max = sum;
        // for (int i = k; i < nums.Length; i++)
        // {
        //     sum = -nums[i - k] + nums[i] + sum;
        //     max = max > sum ? max : sum;
        // }
        // return max / k;
        double sum = 0;
        double max = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            //入
            sum += nums[i];
            if (i < k - 1)
                continue;
            //更新
            max = Math.Max(sum, max);
            //出
            sum -= nums[i - k + 1];
        }
        return max / k;
    }
}
// @lc code=end

