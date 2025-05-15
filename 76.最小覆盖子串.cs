/*
 * @lc app=leetcode.cn id=76 lang=csharp
 *
 * [76] 最小覆盖子串
 */

// @lc code=start
public class Solution76
{
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length)
            return "";
        int[] cntT = new int[128];
        foreach (char item in t)
        {
            cntT[item]++;
        }
        int left = 0;
        int ansL = -1;
        int ansR = s.Length - 1;
        int[] cntS = new int[128];
        for (int right = 0; right < s.Length; right++)
        {
            //in
            char x = s[right];
            cntS[x]++;
            //out
            while (isMatch(cntS, cntT))
            {
                if (right - left < ansR - ansL)
                {
                    ansL = left;
                    ansR = right;
                }
                char ch = s[left];
                cntS[ch]--;
                left++;
            }
        }
        return ansL < 0 ? "" : s.Substring(ansL, ansR - ansL + 1);
    }
    public bool isMatch(int[] cntS, int[] cntT)
    {
        for (int i = 'A'; i <= 'Z'; i++)
        {
            if (cntT[i] > cntS[i])
                return false;
        }
        for (int i = 'a'; i <= 'z'; i++)
        {
            if (cntT[i] > cntS[i])
                return false;
        }
        return true;
    }
}
// @lc code=end

