/*
 * @lc app=leetcode.cn id=438 lang=csharp
 *
 * [438] 找到字符串中所有字母异位词
 */

// @lc code=start
public class Solution438
{
    public IList<int> FindAnagrams(string s, string p)
    {
        List<int> ans = new List<int>();
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        int k = p.Length;
        foreach (char item in p)
        {
            arr1[item - 'a']++;
        }
        for (int i = 0; i < s.Length; i++)
        {
            //in

            if (i < k - 1)
                continue;
            //update
            if (arr1.SequenceEqual(arr2))
                ans.Add(i - k + 1);
            //out
            arr2[s[i - k + 1] - 'a']--;
        }
        return ans;
    }
}
// @lc code=end

