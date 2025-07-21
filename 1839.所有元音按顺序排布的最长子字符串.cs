public class Solution1839
{
    public int LongestBeautifulSubstring(string word)
    {
        int n = word.Length;
        if (n < 5) return 0;  // 最短的“aeiou”长度就是 5

        int ans = 0;
        int currLen = 1;     // 当前考察的子串长度
        int groups = 1;      // 当前子串中“严格升序”（元音分组）的数量
        char prev = word[0];

        for (int i = 1; i < n; i++)
        {
            char c = word[i];
            if (c < prev)
            {
                // 出现下降：必须从这里重置
                currLen = 1;
                groups = 1;
            }
            else
            {
                // 不是下降，长度 +1
                currLen++;
                if (c > prev)
                {
                    // 真正“升”了，分组数 +1
                    groups++;
                }
                // 只有当我们已经经历了 a→e→i→o→u 5 个阶段
                if (groups == 5)
                {
                    ans = Math.Max(ans, currLen);
                }
            }
            prev = c;
        }

        return ans;
    }
}
