/*
 * @lc app=leetcode.cn id=2824 lang=csharp
 *
 * [2824] 统计和小于目标的下标对数目
 */

// @lc code=start
public class Solution2824
{
    public int CountPairs(IList<int> nums, int target)
    {
        int[] arr = nums.ToArray();
        Array.Sort(arr);
        int l = 0;
        int length = arr.Length;
        int r = length - 1;
        int sum = target - 1;
        int ans = 0;
        while (l < r)
        {
            sum = arr[l] + arr[r];
            if (sum >= target)
            {
                r--;
            }
            else
            {
                ans += r - l;
                l++;
            }


        }
        return ans;
    }
}
// @lc code=end

