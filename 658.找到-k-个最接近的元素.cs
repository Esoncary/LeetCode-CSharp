/*
 * @lc app=leetcode.cn id=658 lang=csharp
 *
 * [658] 找到 K 个最接近的元素
 */

// @lc code=start
public class Solution658
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        // int length = arr.Length;
        // int left = 0;
        // int right = length - 1;
        // while (right - left + 1 > k)
        // {
        //     int a = Math.Abs(arr[left] - x);
        //     int b = Math.Abs(arr[right] - x);
        //     if (a < b || (a == b && arr[left] < arr[right]))
        //     {
        //         right--;
        //     }
        //     else
        //     {
        //         left++;
        //     }
        // }
        // List<int> ans = new List<int>();
        // for (int i = left; i <= right; i++)
        // {
        //     ans.Add(arr[i]);
        // }
        // return ans;
        int right = lower_bound(arr, x);
        int left = right - 1;
        while (k-- > 0)
        {
            if (left < 0)
            {
                right++;
            }
            else if (right >= arr.Length)
            {
                left--;
            }
            else if (x - arr[left] <= arr[right] - x)
            {
                left--;
            }
            else
            {
                right++;
            }
        }
        IList<int> ans = new List<int>();
        for (int i = left + 1; i < right; i++)
        {
            ans.Add(arr[i]);
        }
        return ans;
    }
    //二分
    public int lower_bound(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] >= target)
                r = mid;
            else
                l = mid;
        }
        return r;
    }
}
// @lc code=end

