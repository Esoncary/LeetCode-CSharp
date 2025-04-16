/*
 * @lc app=leetcode.cn id=448 lang=csharp
 *
 * [448] 找到所有数组中消失的数字
 */

// @lc code=start
public class Solution448
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        int n = nums.Length;
        // int[] arr = new int[n + 1];
        // foreach (int i in nums)
        // {
        //     arr[i] = 1;
        // }
        List<int> list = new List<int>();
        // for (int i = 1; i <= nums.Length; i++)
        // {
        //     if (arr[i] != 1)
        //         list.Add(i);
        // }


        //原地哈希
        for (int i = 0; i < n; i++)
        {
            int index = Math.Abs(nums[i]) - 1;
            if (nums[index] > 0)
                nums[index] *= -1;
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] > 0)
            {
                list.Add(i + 1);
            }
        }
        return list.ToArray();
    }
}
// @lc code=end

