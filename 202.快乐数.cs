/*
 * @lc app=leetcode.cn id=202 lang=csharp
 *
 * [202] 快乐数
 */

// @lc code=start
public class Solution202
{
    public bool IsHappy(int n)
    {
        HashSet<int> seen = new HashSet<int>();
        while (n != 1 && !seen.Contains(n))
        {
            seen.Add(n);
            n = getNext(n);
        }
        return n == 1;
    }
    private int getNext(int n)
    {
        int totalSum = 0;
        while (n > 0)
        {
            int d = n % 10;
            n = n / 10;
            totalSum += d * d;
        }
        return totalSum;
    }
}
// @lc code=end

