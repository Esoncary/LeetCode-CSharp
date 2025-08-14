/*
 * @lc app=leetcode.cn id=1287 lang=csharp
 *
 * [1287] 有序数组中出现次数超过25%的元素
 */

// @lc code=start
public class Solution1287
{
    public int FindSpecialInteger(int[] arr)
    {
        // int n = arr.Length;
        // int i = 0;
        // while (i < n)
        // {
        //     int k = LowerBound(arr, arr[i]);
        //     int j = LowerBound(arr, arr[i] + 1);
        //     if (j - k > n * 0.25)
        //     {
        //         break;
        //     }
        //     i = j;
        // }
        // return arr[i];


        int m = arr.Length / 4;
        // 只需要检查下标 m 和 2m+1
        foreach (int i in new int[] { m, m * 2 + 1 })
        {
            int x = arr[i];
            // 计算 > x 的元素个数 = lowerBound(arr, x+1) - lowerBound(arr, x)
            if (LowerBound(arr, x + 1) - LowerBound(arr, x) > m)
            {
                return x;
            }
        }
        // 如果既不是 arr[m] 也不是 arr[2m+1]，那结果必然是 arr[3m+2]
        return arr[m * 3 + 2];
    }
    private int LowerBound(int[] arr, int target)
    {
        int left = 0, right = arr.Length;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }
}
// @lc code=end

