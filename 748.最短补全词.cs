/*
 * @lc app=leetcode.cn id=748 lang=csharp
 *
 * [748] 最短补全词
 */

// @lc code=start
public class Solution748
{
    public string ShortestCompletingWord(string licensePlate, string[] words)
    {
        int[] cnt = new int[26];
        foreach (char ch in licensePlate)
        {
            if (char.IsLetter(ch))
            {
                ++cnt[char.ToLower(ch) - 'a'];
            }
        }
        int index = -1;
        for (int i = 0; i < words.Length; i++)
        {
            int[] arr = new int[26];
            foreach (char ch in words[i])
            {
                ++arr[ch - 'a'];
            }
            bool ok = true;
            for (int j = 0; j < 26; j++)
            {
                if (cnt[j] > arr[j])
                {
                    ok = false;
                    break;
                }
            }
            if (ok && (index < 0 || words[i].Length < words[index].Length))
            {
                index = i;
            }
        }
        return words[index];
    }
}
// @lc code=end

