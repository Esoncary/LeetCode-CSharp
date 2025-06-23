public class Solution809
{
    public int ExpressiveWords(string s, string[] words)
    {
        // 处理原字符串s，生成字符分组列表
        List<(char c, int len)> groups = new List<(char c, int len)>();
        int i = 0;
        while (i < s.Length)
        {
            char c = s[i];
            int j = i + 1;
            while (j < s.Length && s[j] == c) j++;
            groups.Add((c, j - i));
            i = j;
        }

        int ans = 0;
        foreach (string word in words)
        {
            if (IsStretchy(word, groups))
                ans++;
        }
        return ans;
    }

    private bool IsStretchy(string word, List<(char c, int len)> groups)
    {
        int i = 0; // groups的索引
        int j = 0; // word的索引

        while (i < groups.Count && j < word.Length)
        {
            var group = groups[i];
            char c = word[j];

            // 字符不匹配
            if (c != group.c) return false;

            // 计算word中当前字符的连续长度
            int k = j + 1;
            while (k < word.Length && word[k] == c) k++;
            int wordLen = k - j;
            int groupLen = group.len;

            // 无法通过扩张得到
            if (wordLen > groupLen || (groupLen < 3 && wordLen != groupLen))
                return false;

            i++;
            j = k;
        }

        // 检查是否处理完所有字符
        return i == groups.Count && j == word.Length;
    }
}