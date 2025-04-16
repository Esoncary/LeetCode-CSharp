/*
 * @lc app=leetcode.cn id=350 lang=csharp
 *
 * [350] 两个数组的交集 II
 */

// @lc code=start
public class Solution350
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        List<int> h1 = new List<int>();
        List<int> res = new List<int>();
        foreach (int i in nums1)
        {
            h1.Add(i);
        }
        foreach (int i in nums2)
        {
            if (h1.Contains(i))
            {
                res.Add(i);
                h1.Remove(i);
            }
        }
        int[] arr = new int[res.Count];
        res.CopyTo(arr);
        return arr;
    }
}
// @lc code=end

