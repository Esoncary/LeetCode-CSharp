/*
 * @lc app=leetcode.cn id=383 lang=csharp
 *
 * [383] 赎金信
 */

// @lc code=start
public class Solution383
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        //magazine的字符要>=ransomNote
        // List<char> mag = new List<char>();
        // foreach (char i in magazine)
        // {
        //     mag.Add(i);
        // }
        // foreach (char j in ransomNote)
        // {
        //     if (!mag.Contains(j))
        //         return false;
        //     mag.Remove(j);
        // }
        // return true;

        if (ransomNote.Length > magazine.Length)
        {
            return false;
        }
        int[] cnt = new int[26];
        foreach (char c in magazine)
        {
            cnt[c - 'a']++;
        }
        foreach (char c in ransomNote)
        {
            cnt[c - 'a']--;
            if (cnt[c - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

