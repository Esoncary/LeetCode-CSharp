/*
 * @lc app=leetcode.cn id=1297 lang=csharp
 *
 * [1297] 子串的最大出现次数
 */

// @lc code=start
using System.Linq.Expressions;
using System.Text;

public class Solution1297
{
    public int MaxFreq(string s, int maxLetters, int minSize, int maxSize)
    {
        int n = s.Length;
        int k = minSize;
        int max = 0;
        while (k <= maxSize)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int[] count = new int[26];
            int uniqueCount = 0; // 记录当前窗口中不同字符的数量
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                // in
                int charIndex = s[i] - 'a';
                if (count[charIndex] == 0) uniqueCount++;
                count[charIndex]++;
                sb.Append(s[i]);

                // 确保窗口大小为 k
                if (sb.Length > k)
                {
                    int removeIndex = sb[0] - 'a';
                    count[removeIndex]--;
                    if (count[removeIndex] == 0) uniqueCount--;
                    sb.Remove(0, 1);
                }

                // 检查窗口是否满足条件
                if (sb.Length == k && uniqueCount <= maxLetters)
                {
                    string substring = sb.ToString();
                    if (!dic.ContainsKey(substring))
                    {
                        dic.Add(substring, 1);
                    }
                    else
                    {
                        dic[substring]++;
                    }
                    max = Math.Max(max, dic[substring]);
                }
            }
            k++;
        }
        return max;
    }
}
// @lc code=end

