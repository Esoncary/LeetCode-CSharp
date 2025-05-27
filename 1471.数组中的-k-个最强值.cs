/*
 * @lc app=leetcode.cn id=1471 lang=csharp
 *
 * [1471] 数组中的 k 个最强值
 */

// @lc code=start
public class Solution1471
{
    public int[] GetStrongest(int[] arr, int k)
    {
        //|arr[i] - m| > |arr[j] - m|
        //距离远的大
        //|arr[i] - m| == |arr[j] - m|，且 arr[i] > arr[j]
        //距离相等的 大的厉害

        //求出中位数
        Array.Sort(arr);
        int n = arr.Length;
        int m = arr[((n - 1) / 2)];

        int cnt = 0;
        int r = n - 1;
        int l = 0;
        int[] ans = new int[k];
        while (cnt < k)
        {

            if (Math.Abs(arr[l] - m) > Math.Abs(arr[r] - m) || (Math.Abs(arr[l] - m) == Math.Abs(arr[r] - m) && arr[l] > arr[r]))
            {
                ans[cnt] = arr[l];
                l++;
            }
            else if (Math.Abs(arr[l] - m) < Math.Abs(arr[r] - m) || (Math.Abs(arr[l] - m) == Math.Abs(arr[r] - m) && arr[l] < arr[r]))
            {
                ans[cnt] = arr[r];
                r--;
            }
            else
            {
                ans[cnt] = arr[r];
                r--;
            }
            cnt++;
        }
        return ans;
    }
}
// @lc code=end

