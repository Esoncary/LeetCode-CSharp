/*
 * @lc app=leetcode.cn id=1385 lang=csharp
 *
 * [1385] 两个数组间的距离值
 */

// @lc code=start
public class Solution1385
{
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        int n1 = arr1.Length;
        int n2 = arr2.Length;

        int ans = 0;
        //暴力
        // for (int i = 0; i < n1; i++)
        // {
        //     int j = 0;
        //     while (j < n2)
        //     {
        //         if (Math.Abs(arr1[i] - arr2[j]) <= d)
        //         {
        //             break;
        //         }
        //         j++;
        //     }
        //     if (j == n2)
        //         ans++;
        // }
        // return ans;


        //排序 + 双指针
        Array.Sort(arr1);
        Array.Sort(arr2);
        int j = 0;
        foreach (int x in arr1)
        {
            while (j < arr2.Length && arr2[j] < x - d)
            {
                j++;
            }
            if (j == arr2.Length || arr2[j] > x + d)
            {
                ans++;
            }
        }
        return ans;
    }
}
// @lc code=end

