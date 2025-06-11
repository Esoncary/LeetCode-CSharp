/*
 * @lc app=leetcode.cn id=1089 lang=csharp
 *
 * [1089] 复写零
 */

// @lc code=start
using System.Globalization;

public class Solution1089
{
    public void DuplicateZeros(int[] arr)
    {
        //暴力
        // int n = arr.Length;
        // for (int i = 0; i < n; i++)
        // {
        //     if (arr[i] == 0)
        //     {
        //         Move(ref arr, i);
        //         i++;
        //     }
        // }

        //用双指针来模拟栈
        int n = arr.Length;
        int top = 0;
        int i = -1;
        while (top < n)
        {
            i++;
            if (arr[i] == 0)
                top += 2;
            else
                top++;
        }
        int j = n - 1;
        //最后一个数如果为0
        if (top == n + 1)
        {
            arr[j] = 0;
            j--;
            i--;
        }

        while (j >= 0)
        {
            arr[j] = arr[i];
            j--;
            if (arr[i] == 0)
            {
                arr[j] = arr[i];
                j--;
            }
            i--;
        }
    }
    // public void Move(ref int[] arr, int k)
    // {
    //     int n = arr.Length;
    //     for (int i = n - 1; i > k; i--)
    //     {
    //         arr[i] = arr[i - 1];
    //     }
    // }
}
// @lc code=end

