/*
 * @lc app=leetcode.cn id=30 lang=csharp
 *
 * [30] 串联所有单词的子串
 */

// @lc code=start
public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        // int length = words[0].Length;
        // int k = words.Length * length;
        // int n = s.Length;
        // Dictionary<string, int> dic = new Dictionary<string, int>();

        // List<int> ans = new List<int>();
        // foreach (string item in words)
        // {
        //     if (!dic.ContainsKey(item))
        //         dic.Add(item, 1);
        //     else
        //         dic[item]++;
        // }
        // string temp = "";
        // for (int i = 0; i < n; i++)
        // {
        //     Dictionary<string, int> tDic = new Dictionary<string, int>(dic);
        //     //in
        //     temp += s[i];
        //     if (i < k - 1)
        //         continue;
        //     //update
        //     for (int j = 0; j < k; j += length)
        //     {
        //         if (tDic.ContainsKey(temp.Substring(j, length)) && tDic[temp.Substring(j, length)] > 0)
        //             tDic[temp.Substring(j, length)]--;
        //         else
        //         {
        //             break;
        //         }
        //         //if (tDic[temp.Substring(j, length)] != 0)
        //     }
        //     if (AllValuesZero(tDic))
        //         ans.Add(i - k + 1);
        //     //out
        //     temp = temp.Remove(0, 1);
        // }
        // return ans;
        if (string.IsNullOrEmpty(s) || words.Length == 0)
            return new List<int>();

        int wordLength = words[0].Length;
        int totalLength = words.Length * wordLength;
        int n = s.Length;
        Dictionary<string, int> wordCount = new Dictionary<string, int>();
        List<int> result = new List<int>();

        // 统计每个单词的出现次数
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount.Add(word, 1);
        }

        // 按照单词长度进行分组遍历
        for (int offset = 0; offset < wordLength; offset++)
        {
            int left = offset;
            int right = offset;
            Dictionary<string, int> currentCount = new Dictionary<string, int>();

            while (right + wordLength <= n)
            {
                string subWord = s.Substring(right, wordLength);
                right += wordLength;

                if (wordCount.ContainsKey(subWord))
                {
                    if (currentCount.ContainsKey(subWord))
                        currentCount[subWord]++;
                    else
                        currentCount.Add(subWord, 1);

                    while (currentCount[subWord] > wordCount[subWord])
                    {
                        string removeWord = s.Substring(left, wordLength);
                        left += wordLength;
                        currentCount[removeWord]--;
                        if (currentCount[removeWord] == 0)
                            currentCount.Remove(removeWord);
                    }

                    if (right - left == totalLength)
                    {
                        result.Add(left);
                        string removeWord = s.Substring(left, wordLength);
                        currentCount[removeWord]--;
                        if (currentCount[removeWord] == 0)
                            currentCount.Remove(removeWord);
                        left += wordLength;
                    }
                }
                else
                {
                    currentCount.Clear();
                    left = right;
                }
            }
        }

        return result;
    }
    public bool AllValuesZero(Dictionary<string, int> dic)
    {
        foreach (var value in dic.Values)
        {
            if (value != 0)
            {
                return false;
            }
        }
        return true;
    }
}
// @lc code=end

