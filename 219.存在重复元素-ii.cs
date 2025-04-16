/*
 * @lc app=leetcode.cn id=219 lang=csharp
 *
 * [219] 存在重复元素 II
 */

// @lc code=start
public class Solution219
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        //哈希
        // Dictionary<int, int> dic = new Dictionary<int, int>();
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (!dic.ContainsKey(nums[i]))
        //     {
        //         dic.Add(nums[i], i);
        //     }
        //     else
        //     {
        //         if (Math.Abs(i - dic[nums[i]]) <= k)
        //         {
        //             return true;
        //         }
        //         else
        //         {
        //             dic[nums[i]] = i;
        //         }
        //     }
        // }
        // return false;

        //滑动窗口
        HashSet<int> hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (i > k)
            {
                hash.Remove(nums[i - k - 1]);
            }
            if (!hash.Add(nums[i]))
            {
                return true;
            }

        }
        return false;
    }
}
// @lc code=end

