/*
 * @lc app=leetcode.cn id=1002 lang=csharp
 *
 * [1002] 查找共用字符
 */

// @lc code=start
public class Solution1002
{
    public IList<string> CommonChars(string[] words)
    {
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        List<string> list = new List<string>();
        foreach (char c in words[0])
        {
            arr1[c - 'a']++;
        }
        for (int i = 1; i < words.Length; i++)
        {
            arr2 = new int[26];
            foreach (char c in words[i])
            {
                arr2[c - 'a']++;
            }
            for (int j = 0; j < 26; j++)
            {
                arr1[j] = Math.Min(arr1[j], arr2[j]);
            }
        }
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < arr1[i]; j++)
            {
                list.Add(((char)(i + 'a')).ToString());
            }
        }
        return list;
    }
}
// @lc code=end

