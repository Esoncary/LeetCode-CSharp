/*
 * @lc app=leetcode.cn id=191 lang=csharp
 *
 * [191] 位1的个数
 */

// @lc code=start
public class Solution191 {
    public int HammingWeight(int n) {
        //解法1：
        int count = 0;
        // while( n != 0)
        // {
        //     if(n % 2 == 1) count++;
        //     n /= 2;
        // }

        //解法2：n & (n - 1)会把n中最后一个1变为0
        while(n > 0)
        {
            n &= (n -1);
            count++;
        }
        return count;
    }
}
// @lc code=end

