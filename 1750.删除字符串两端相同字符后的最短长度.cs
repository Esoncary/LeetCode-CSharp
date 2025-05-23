/*
 * @lc app=leetcode.cn id=1750 lang=csharp
 *
 * [1750] 删除字符串两端相同字符后的最短长度
 */

// @lc code=start
public class Solution1750
{
    public int MinimumLength(string s)
    {
        char[] arr = s.ToCharArray();
        int left = 0;
        int right = arr.Length - 1;
        while (left < right && arr[left] == arr[right])
        {
            char temp = arr[left];
            while (left <= right && arr[left] == temp)
            {
                left++;
            }
            while (left <= right && arr[right] == temp)
            {
                right--;
            }

        }
        return right - left + 1;
    }
}
// @lc code=end

