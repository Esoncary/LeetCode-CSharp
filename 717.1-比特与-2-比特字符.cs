/*
 * @lc app=leetcode.cn id=717 lang=csharp
 *
 * [717] 1 比特与 2 比特字符
 */

// @lc code=start
public class Solution717
{
    public bool IsOneBitCharacter(int[] bits)
    {
        //正序

        //我们可以对 bits 数组从左到右遍历。当遍历到 bits[i] 时，如果 bits[i] = 0，说明遇到了第一种字符，将 i 的值增加 1；如果 bits[i] = 1，说明遇到了第二种字符，可以跳过 bits[i + 1]，将 i 的值增加 2。

        //上述流程也说明 bits 的编码方式是唯一确定的，因此若遍历到 i = n−1，那么说明最后一个字符一定是第一种字符。

        int n = bits.Length, i = 0;
        while (i < n - 1)
        {
            i += bits[i] + 1;
        }
        return i == n - 1;

        //倒叙
        //根据题意，0 一定是一个字符的结尾。
        // 我们可以找到 bits 的倒数第二个 0 的位置，记作 i（不存在时定义为 −1），那么 bits[i + 1] 一定是一个字符的开头，且从 bits[i + 1] 到 bits[n−2] 的这 n−2−i 个比特均为 1。
        // 如果 n−2−i 为偶数，一定组成了第一种字符。
        // 如果 n−2−i 为奇数，组成第二种字符。

        // int n = bits.Length, i = n - 2;
        // while (i >= 0 && bits[i] == 1)
        // {
        //     --i;
        // }
        // return (n - i) % 2 == 0;
    }
}
// @lc code=end

