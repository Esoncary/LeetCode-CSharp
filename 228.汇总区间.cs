/*
 * @lc app=leetcode.cn id=228 lang=csharp
 *
 * [228] 汇总区间
 */

// @lc code=start
public class Solution228
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> list = new List<string>();
        int i = 0;
        int j = 1;
        if (nums.Length == 0) return list;
        while (j <= nums.Length)
        {
            if (j < nums.Length && nums[j] - nums[i] == j - i)
            {
                j++;
            }
            else
            {
                if (i == j - 1)
                {
                    list.Add(nums[i].ToString());
                }
                else
                {
                    list.Add($"{nums[i]}->{nums[j - 1]}");
                }
                i = j;
                j++;
            }

        }
        return list;
    }
}
// @lc code=end

