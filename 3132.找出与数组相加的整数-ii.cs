/*
 * @lc app=leetcode.cn id=3132 lang=csharp
 *
 * [3132] 找出与数组相加的整数 II
 */

// @lc code=start
public class Solution3132
{
    public int MinimumAddedInteger(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        // int ans = int.MaxValue;
        // for (int i = 0; i <= nums1.Length - nums2.Length; i++)
        // {
        //     int p = i;
        //     int q = 0;
        //     int diff = nums2[q] - nums1[p];//x
        //     if (diff > ans)
        //     {
        //         continue;
        //     }
        //     while (p < nums1.Length && q < nums2.Length)
        //     {
        //         if (Math.Abs(p - q) > nums1.Length - nums2.Length)
        //         {
        //             break;
        //         }
        //         if (nums2[q] - nums1[p] == diff)
        //         {
        //             p++;
        //             q++;
        //         }
        //         else if (nums2[q] - nums1[p] > diff)
        //         {
        //             p++;
        //         }
        //         else
        //         {
        //             break;
        //         }
        //     }
        //     if (q == nums2.Length && Math.Abs(p - q) <= nums1.Length - nums2.Length)
        //     {
        //         ans = ans > diff ? diff : ans;
        //     }
        // }
        // return ans;

        // 枚举保留 nums1[2] 或者 nums1[1] 或者 nums1[0]
        // 倒着枚举是因为 nums1[i] 越大答案越小，第一个满足的就是答案
        for (int i = 2; i > 0; i--)
        {
            int x = nums2[0] - nums1[i];
            int j = 0;
            for (int k = i; k < nums1.Length; k++)
            {
                if (nums2[j] == nums1[k] + x && ++j == nums2.Length)
                {
                    // nums2 是 {nums1[i] + x} 的子序列
                    return x;
                }
            }
        }
        return nums2[0] - nums1[0];
    }
}
// @lc code=end

