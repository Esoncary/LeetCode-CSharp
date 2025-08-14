/*
 * @lc app=leetcode.cn id=1283 lang=csharp
 *
 * [1283] 使结果不超过阈值的最小除数
 */

// @lc code=start
public class Solution1283
{
    public int SmallestDivisor(int[] nums, int threshold)
    {
        //threshold>= nums.Length,所以m一定在1~nums[max]里
        int l = 0;
        int r = -1;
        foreach (var item in nums)
        {
            r = Math.Max(item, r);
        }

        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (check(mid, nums, threshold))
                r = mid;
            else
                l = mid;
        }
        return r;
    }
    public bool check(int mid, int[] nums, int threshold)//mid作为除数后，他的和是否大于threshold
    {
        int sum = 0;
        foreach (int item in nums)
        {
            sum += (item + mid - 1) / mid;//向上取整
            if (sum > threshold)
                return false;
        }
        return true;
    }
}
// @lc code=end

