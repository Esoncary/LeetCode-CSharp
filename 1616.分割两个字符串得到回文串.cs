/*
 * @lc app=leetcode.cn id=1616 lang=csharp
 *
 * [1616] 分割两个字符串得到回文串
 */

// @lc code=start
public class Solution1616
{
    public bool CheckPalindromeFormation(string a, string b)
    {
        return Check(a, b) || Check(b, a);

    }
    public bool Check(string a, string b)
    {
        int n = a.Length;
        int l = 0;
        int r = n - 1;
        while (l < r && a[l] == b[r])
        {
            l++;
            r--;
        }
        return isPalindrome(a, l, r) || isPalindrome(b, l, r);
    }
    public bool isPalindrome(string a, int l, int r)
    {
        while (l < r && a[l] == a[r])
        {
            l++;
            r--;
        }
        return l >= r;
    }
}
// @lc code=end

