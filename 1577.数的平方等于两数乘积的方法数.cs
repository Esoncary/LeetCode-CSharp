/*
 * @lc app=leetcode.cn id=1577 lang=csharp
 *
 * [1577] 数的平方等于两数乘积的方法数
 */

// @lc code=start
public class Solution1577
{
    public int NumTriplets(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);
        return Cnt(nums1, nums2) + Cnt(nums2, nums1);

    }
    public int Cnt(int[] nums1, int[] nums2)
    {
        int n1 = nums1.Length;
        int n2 = nums2.Length;

        int ans = 0;
        for (int i = 0; i < n1; i++)
        {
            int l = 0;
            int r = n2 - 1;
            //固定nums1[i]
            while (l < r)
            {
                if ((long)nums1[i] * nums1[i] > (long)nums2[l] * nums2[r])
                {
                    l++;
                }
                else if ((long)nums1[i] * nums1[i] < (long)nums2[l] * nums2[r])
                {
                    r--;
                }
                else
                {
                    if (nums2[l] == nums2[r])
                    {
                        ans += (r - l + 1) * (r - l) / 2;
                        break;
                    }
                    else
                    {
                        int t1 = 0;
                        int t2 = 0;
                        long temp1 = nums2[l];
                        long temp2 = nums2[r];
                        while (temp1 == nums2[l])
                        {
                            t1++;
                            l++;
                        }
                        while (temp2 == nums2[r])
                        {
                            t2++;
                            r--;
                        }
                        ans += t1 * t2;
                    }
                }
            }

        }
        return ans;
    }
}
// @lc code=end

