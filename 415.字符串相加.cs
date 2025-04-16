/*
 * @lc app=leetcode.cn id=415 lang=csharp
 *
 * [415] 字符串相加
 */

// @lc code=start
using System.Numerics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

public class Solution415
{
    public string AddStrings(string num1, string num2)
    {
        int i = num1.Length - 1;
        int j = num2.Length - 1;
        StringBuilder ans = new StringBuilder();
        int carry = 0;
        int n1, n2;
        while (i >= 0 || j >= 0)
        {
            n1 = i >= 0 ? num1[i] - '0' : 0;
            n2 = j >= 0 ? num2[j] - '0' : 0;
            int sum = n1 + n2 + carry;
            carry = sum / 10;
            ans.Append(sum % 10);
            i--; j--;
        }
        // 处理最后的进位
        if (carry > 0)
        {
            ans.Append(carry);
        }
        object a = new object();
        // 反转结果
        return new string(ans.ToString().Reverse().ToArray());
    }
}
// @lc code=end

