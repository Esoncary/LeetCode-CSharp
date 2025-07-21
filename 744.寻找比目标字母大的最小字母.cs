/*
 * @lc app=leetcode.cn id=744 lang=csharp
 *
 * [744] 寻找比目标字母大的最小字母
 */

// @lc code=start
public class Solution744
{
    public char NextGreatestLetter(char[] letters, char target)
    {
        return lower_bound(letters, (char)(target + 1)) >= letters.Length ? letters[0] : letters[lower_bound(letters, (char)(target + 1))];
    }
    public int lower_bound(char[] letters, char target)
    {
        int l = -1;
        int r = letters.Length;
        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (letters[mid] < target)
                l = mid;
            else
                r = mid;
        }
        return r;
    }
}
// @lc code=end

