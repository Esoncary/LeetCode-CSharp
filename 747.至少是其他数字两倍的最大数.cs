/*
 * @lc app=leetcode.cn id=747 lang=csharp
 *
 * [747] 至少是其他数字两倍的最大数
 */

// @lc code=start
public class Solution747
{
    public int DominantIndex(int[] nums)
    {
        //0 为第二大 1 为最大 2为下标
        int[] max = new int[3] { int.MinValue, int.MinValue, -1 };
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > max[1])
            {
                max[0] = max[1];
                max[1] = nums[i];
                max[2] = i;
            }
            else if (nums[i] > max[0])
            {
                max[0] = nums[i];
            }
        }
        return max[0] * 2 <= max[1] ? max[2] : -1;
    }
}
// @lc code=end

