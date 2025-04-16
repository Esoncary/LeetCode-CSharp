/*
 * @lc app=leetcode.cn id=349 lang=csharp
 *
 * [349] 两个数组的交集
 */

// @lc code=start
public class Solution349
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        int count1 = nums1.Length;
        int count2 = nums2.Length;
        HashSet<int> res = new HashSet<int>();
        int i = 0;
        int j = 0;
        int k = 0;
        Array.Sort(nums1);
        Array.Sort(nums2);
        while (i < count1 && j < count2)
        {
            if (nums1[i] < nums2[j])
            {
                i++;
            }
            else if (nums1[i] > nums2[j])
            {
                j++;
            }
            else
            {
                if (!res.Contains(nums1[i]))
                    res.Add(nums1[i]); k++;
                i++;
                j++;
            }
        }
        int[] arr = new int[res.Count];
        res.CopyTo(arr);
        return arr;
    }
}
// @lc code=end

