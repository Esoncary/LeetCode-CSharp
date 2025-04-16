/*
 * @lc app=leetcode.cn id=1343 lang=csharp
 *
 * [1343] 大小为 K 且平均值大于等于阈值的子数组数目
 */

// @lc code=start
public class Solution1343
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        int sum = 0;
        int ans = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            //入
            sum += arr[i];
            if (i < k - 1)
                continue;
            //更新
            ans = sum >= threshold * k ? ans + 1 : ans;
            //出
            sum -= arr[i - k + 1];
        }
        return ans;
    }
}
// @lc code=end

