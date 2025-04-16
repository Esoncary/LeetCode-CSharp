/*
 * @lc app=leetcode.cn id=374 lang=csharp
 *
 * [374] 猜数字大小
 */

// @lc code=start
/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution374 : GuessGame
{
    public int GuessNumber(int n)
    {
        int left = 1;
        int right = n;
        int mid = 0;
        int r = -1;
        while (r != 0)
        {
            mid = left + (right - left) / 2;
            r = guess(mid);
            if (r > 0)
            {
                left = mid + 1;
            }
            else if (r < 0)
            {
                right = mid - 1;
            }
        }
        return mid;
    }
    public int guess(int m)
    {
        return -1;
    }
}
public class GuessGame
{

}
// @lc code=end

