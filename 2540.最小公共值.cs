/*
 * @lc app=leetcode.cn id=2540 lang=csharp
 *
 * [2540] 最小公共值
 */

// @lc code=start
public class Solution2540
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        int i = 0;
        int j = 0;
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        while (i < n1 && j < n2)
        {
            if (nums1[i] > nums2[j])
            {
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                return nums1[i];
            }
        }
        return -1;
    }
}
// @lc code=end

