/*
 * @lc app=leetcode.cn id=278 lang=csharp
 *
 * [278] 第一个错误的版本
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

interface VersionControl
{ }

public class Solution278 : VersionControl
{
    public int FirstBadVersion(int n)
    {

        //二分查找
        int low = 1;
        int heigh = n;
        int mid;
        while (low < heigh)
        {
            mid = low + (heigh - low) / 2;
            if (IsBadVersion(mid))
            {
                heigh = mid;
            }
            else
            {
                low = mid + 1;
            }
        }
        return low;
    }
    public bool IsBadVersion(int a)
    {
        return true;
    }
}
// @lc code=end

