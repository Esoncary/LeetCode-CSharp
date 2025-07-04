/*
 * @lc app=leetcode.cn id=845 lang=csharp
 *
 * [845] 数组中的最长山脉
 */

// @lc code=start
public class Solution845
{
    public int LongestMountain(int[] arr)
    {
        int ans = 0;
        int n = arr.Length;
        if (n < 3)
            return ans;
        for (int i = 1; i < n - 1; i++)
        {
            int cnt = 0;
            if (!(arr[i] > arr[i - 1] && arr[i] > arr[i + 1]))
                continue;
            int j = i;
            while (j > 0 && arr[j] > arr[j - 1])
                j--;
            while (i < n - 1 && arr[i] > arr[i + 1])
                i++;
            ans = Math.Max(ans, i - j + 1);
        }
        return ans;

    }
}
// @lc code=end

