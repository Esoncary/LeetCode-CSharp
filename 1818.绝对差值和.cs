using System;
using System.Collections.Generic;

public class Solution1818
{
    public int MinAbsoluteSumDiff(int[] nums1, int[] nums2)
    {
        const int MOD = 1_000_000_007;
        int n = nums1.Length;

        // 计算所有差值的和
        long targetSum = 0;
        for (int i = 0; i < n; i++)
        {
            targetSum = (targetSum + Math.Abs(nums1[i] - nums2[i])) % MOD;
        }

        // 准备排序后的副本用于二分查找
        int[] sortedNums = new int[n];
        Array.Copy(nums1, sortedNums, n);
        Array.Sort(sortedNums);

        // 计算最大能减少的差值
        int maxDiff = 0;
        for (int i = 0; i < n; i++)
        {
            int x = nums1[i];
            int y = nums2[i];
            int curDiff = Math.Abs(x - y);

            // 在 sortedNums 中查找第一个 >= y 的索引
            int j = LowerBound(sortedNums, y);

            // 尝试当前位置 j
            if (j < n)
            {
                maxDiff = Math.Max(maxDiff, curDiff - Math.Abs(sortedNums[j] - y));
            }
            // 也尝试前一个位置 j-1
            if (j > 0)
            {
                maxDiff = Math.Max(maxDiff, curDiff - Math.Abs(sortedNums[j - 1] - y));
            }
        }

        // 应用最大优化，保证结果非负
        long result = (targetSum - maxDiff + MOD) % MOD;
        return (int)result;
    }

    // 自定义 LowerBound: 返回第一个 >= target 的索引
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
