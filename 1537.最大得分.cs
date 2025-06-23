/*
 * @lc app=leetcode.cn id=1537 lang=csharp
 *
 * [1537] 最大得分
 */

// @lc code=start
public class Solution1537
{
    public int MaxSum(int[] nums1, int[] nums2)
    {
        // const int MOD = 1_000_000_007;
        // long ans = 0;
        // int i = 0;
        // int j = 0;
        // int idx = 0;
        // long[] cnt1 = new long[nums1.Length];
        // long[] cnt2 = new long[nums2.Length];
        // while (i < nums1.Length && j < nums2.Length)
        // {
        //     if (nums1[i] > nums2[j])
        //     {
        //         cnt2[idx] += nums2[j++];
        //     }
        //     else if (nums1[i] < nums2[j])
        //     {
        //         cnt1[idx] += nums1[i++];
        //     }
        //     else
        //     {
        //         cnt1[idx] += nums1[i++];
        //         cnt2[idx] += nums2[j++];
        //         idx++;
        //     }
        // }
        // while (i < nums1.Length)
        // {
        //     cnt1[idx] += nums1[i++];
        // }
        // while (j < nums2.Length)
        // {
        //     cnt2[idx] += nums2[j++];
        // }

        // for (int z = 0; z <= idx; z++)
        // {
        //     ans = (ans + Math.Max(cnt1[z], cnt2[z])) % MOD;
        // }
        // return (int)ans;
        int i = 0, j = 0;
        long sum1 = 0, sum2 = 0, ans = 0;
        const int MOD = 1_000_000_007;

        // 双指针遍历
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                sum1 += nums1[i++];
            }
            else if (nums1[i] > nums2[j])
            {
                sum2 += nums2[j++];
            }
            else
            {
                // 相等时，选取两条路径（不含当前相等值）的最大前缀和，再加上这个交点值
                ans = (ans + Math.Max(sum1, sum2) + nums1[i]) % MOD;
                i++;
                j++;
                sum1 = 0;
                sum2 = 0;
            }
        }

        // 把剩余部分继续累加到各自的 sum 上
        while (i < nums1.Length) sum1 += nums1[i++];
        while (j < nums2.Length) sum2 += nums2[j++];

        // 最后一段也要选最大
        ans = (ans + Math.Max(sum1, sum2)) % MOD;
        return (int)ans;

    }
}
// @lc code=end

