/*
 * @lc app=leetcode.cn id=389 lang=csharp
 *
 * [389] 找不同
 */

// @lc code=start
public class Solution389
{
    public char FindTheDifference(string s, string t)
    {
        //数组计数
        // char count = ' ';
        // int[] arr = new int[26];
        // foreach (char i in s)
        // {
        //     arr[i - 'a'] += 1;
        // }
        // foreach (char i in t)
        // {
        //     arr[i - 'a'] -= 1;
        //     if (arr[i - 'a'] == -1)
        //     {
        //         count = i;
        //     }
        // }
        // return count;

        //求和
        // int sum = 0;
        // foreach (char i in t)
        // {
        //     sum += i;
        // }
        // foreach (char i in s)
        // {
        //     sum -= i;
        // }
        // return (char)sum;

        //位运算
        int sum = 0;
        foreach (char i in t)
        {
            sum ^= i;
        }
        foreach (char i in s)
        {
            sum ^= i;
        }
        return (char)sum;
    }
}
// @lc code=end

