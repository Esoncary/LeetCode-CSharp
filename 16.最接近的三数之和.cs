/*
 * @lc app=leetcode.cn id=16 lang=csharp
 *
 * [16] 最接近的三数之和
 */

// @lc code=start
public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        int length = nums.Length;
        Array.Sort(nums);
        int diff = int.MaxValue;
        int ans = 0;
        for (int i = 0; i < length - 2; i++)
        {
            int x = nums[i];
            int l = i + 1;
            int r = length - 1;

            while (l < r)
            {
                int sum = x + nums[l] + nums[r];
                if (sum == target)
                {
                    return sum;
                }
                else if (sum > target)
                {
                    diff = sum - target > diff ? diff : sum - target;
                    ans = sum - target > diff ? ans : sum;
                    r--;
                }
                else
                {
                    diff = target - sum > diff ? diff : target - sum;
                    ans = target - sum > diff ? ans : sum;
                    l++;
                }
            }

        }
        return ans;
    }
}
// @lc code=end

