/*
 * @lc app=leetcode.cn id=2460 lang=csharp
 *
 * [2460] 对数组执行操作
 */

// @lc code=start
public class Solution2460
{
    public int[] ApplyOperations(int[] nums)
    {
        // int n = nums.Length;
        // for (int i = 0; i < n - 1; i++)
        // {
        //     if (nums[i] == nums[i + 1])
        //     {
        //         nums[i] = nums[i] * 2;
        //         nums[i + 1] = 0;
        //     }
        // }
        // int nonZeroIndex = 0;
        // for (int i = 0; i < n; i++)
        // {
        //     if (nums[i] != 0)
        //     {
        //         nums[nonZeroIndex++] = nums[i];
        //     }
        // }

        // // 填充剩余位置为零
        // for (int i = nonZeroIndex; i < n; i++)
        // {
        //     nums[i] = 0;
        // }
        // return nums;
        int n = nums.Length;
        for (int i = 0, j = 0; i < n; i++)
        {
            if (i + 1 < n && nums[i] == nums[i + 1])
            {
                nums[i] *= 2;
                nums[i + 1] = 0;
            }
            if (nums[i] != 0)
            {
                Swap(nums, i, j);
                j++;
            }
        }
        return nums;
    }

    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}



// @lc code=end

