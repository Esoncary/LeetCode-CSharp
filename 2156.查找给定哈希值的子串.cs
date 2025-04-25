/*
 * @lc app=leetcode.cn id=2156 lang=csharp
 *
 * [2156] 查找给定哈希值的子串
 */

// @lc code=start
public class Solution2156
{
    public string SubStrHash(string s, int power, int modulo, int k, int hashValue)
    {
        char[] arr = s.ToCharArray();
        int n = s.Length;
        long hash = 0;
        long pk = 1;
        //初始化
        for (int i = n - 1; i >= n - k; i--)
        {
            hash = (hash * power + (s[i] & 31)) % modulo;
            pk = (pk * power) % modulo;
        }
        int ans = hash == hashValue ? n - k : 0;
        //滑动窗口
        for (int i = n - k - 1; i >= 0; i--)
        {
            hash = (hash * power + (s[i] & 31) - pk * (s[i + k] & 31) % modulo + modulo) % modulo;
            if (hash == hashValue)
                ans = i;
        }
        return s.Substring(ans, k);
    }
}


// @lc code=end

