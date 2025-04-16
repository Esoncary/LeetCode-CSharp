/*
 * @lc app=leetcode.cn id=941 lang=csharp
 *
 * [941] 有效的山脉数组
 */

// @lc code=start
public class Solution941
{
    public bool ValidMountainArray(int[] arr)
    {
        int i = 0;
        int n = arr.Length;
        while (i + 1 < n && arr[i] < arr[i + 1])
            i++;
        if (i == n - 1 || i == 0)
            return false;
        while (i + 1 < n && arr[i] > arr[i + 1])
            i++;
        return i == n - 1;
    }
}
// @lc code=end

