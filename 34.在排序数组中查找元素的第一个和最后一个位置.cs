/*
 * @lc app=leetcode.cn id=34 lang=csharp
 *
 * [34] 在排序数组中查找元素的第一个和最后一个位置
 */

// @lc code=start
public class Solution34
{
    public int[] SearchRange(int[] nums, int target)
    {
        //即找到>=target第一个位置和<=target的第一个位置
        int start = lower_bound3(nums, target);
        if (start == nums.Length || nums[start] != target)//数组为空或者nums的所有数都小于target || nums找不到target
            return new int[2] { -1, -1 };
        int end = lower_bound3(nums, target + 1) - 1;
        return [start, end];
    }
    public int lower_bound(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length - 1;// 闭区间[l,r]
        while (l <= r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] < target)
                l = mid + 1;//区间为[mid + 1，r]
            else
                r = mid - 1;//区间为[l,mid - 1]
        }
        return l;
    }
    public int lower_bound2(int[] nums, int target)
    {
        int l = 0;
        int r = nums.Length;// 开区间[l,r)
        while (l < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] < target)
                l = mid + 1;//区间为[mid + 1，r)
            else
                r = mid;//区间为[l,mid)
        }
        return l;
    }
    public int lower_bound3(int[] nums, int target)
    {
        int l = -1;
        int r = nums.Length;// 开区间(l,r)
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (nums[mid] < target)
                l = mid;//区间为(mid,r)
            else
                r = mid;//区间为(l,mid)
        }
        return r;
    }
}
// @lc code=end

