/*
 * @lc app=leetcode.cn id=3325 lang=csharp
 *
 * [3325] 字符至少出现 K 次的子字符串 I
 */

// @lc code=start
public class Solution3325
{
    public int NumberOfSubstrings(string s, int k)
    {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int left = 0;
        int ans = 0;
        int length = s.Length;
        for (int right = 0; right < length; right++)
        {
            //in
            char temp = s[right];
            if (!dic.ContainsKey(temp))
            {
                dic.Add(temp, 1);
            }
            else
            {
                dic[temp]++;
            }
            //
            while (isMatch(dic, k))
            {
                ans += length - right;
                dic[s[left]]--;
                if (dic[s[left]] == 0)
                {
                    dic.Remove(s[left]);
                }
                left++;
            }
        }
        return ans;
    }
    public bool isMatch(Dictionary<char, int> dic, int k)
    {
        foreach (int item in dic.Values)
        {
            if (item >= k)
                return true;
        }
        return false;
    }
}
// @lc code=end

