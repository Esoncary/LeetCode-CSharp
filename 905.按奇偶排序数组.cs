/*
 * @lc app=leetcode.cn id=905 lang=csharp
 *
 * [905] 按奇偶排序数组
 */

// @lc code=start
public class Solution905
{
    public int[] SortArrayByParity(int[] nums)
    {
        int n = nums.Length;
        int left = 0;
        int right = n - 1;
        while (left < right)
        {
            while (left < n && nums[left] % 2 == 0)
                left++;
            while (right >= 0 && nums[right] % 2 == 1)
                right--;
            if (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
            }
        }
        return nums;
        // int i = 0;
        // int j = nums.Length - 1;
        // while (i < j)
        // { // 循环直到不足两个数
        //     if (nums[i] % 2 == 0)
        //     { // 寻找最左边的奇数
        //         i++;
        //     }
        //     else if (nums[j] % 2 == 1)
        //     { // 寻找最右边的偶数
        //         j--;
        //     }
        //     else
        //     {
        //         int tmp = nums[i];
        //         nums[i] = nums[j];
        //         nums[j] = tmp;
        //         // 交换后，问题变成 [i+1,j-1] 的子问题
        //         i++;
        //         j--;
        //     }
        // }
        // return nums;
    }
}
// @lc code=end

