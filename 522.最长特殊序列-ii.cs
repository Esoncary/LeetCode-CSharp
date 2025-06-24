public class Solution522
{
    public int FindLUSlength(string[] strs)
    {
        // 先按长度降序排列
        var sorted = strs.OrderByDescending(s => s.Length).ToArray();
        int n = sorted.Length;

        for (int i = 0; i < n; i++)
        {
            string candidate = sorted[i];
            bool isSubsequence = false;

            // 如果后面任何一个字符串能“包掉” candidate，就 不是“特殊序列”
            for (int j = 0; j < n; j++)
            {
                if (i == j) continue;
                if (IsSubseq(candidate, sorted[j]))
                {
                    isSubsequence = true;
                    break;
                }
            }

            // 只有当它不是任何其他串的子序列时，立即返回它的长度
            if (!isSubsequence)
                return candidate.Length;
        }

        // 如果都没找到，返回 -1
        return -1;
    }

    // 判断 s 是否是 t 的子序列
    private bool IsSubseq(string s, string t)
    {
        int si = 0, ti = 0;
        while (si < s.Length && ti < t.Length)
        {
            if (s[si] == t[ti])
                si++;
            ti++;
        }
        // 如果 si 已经走完，说明所有字符都能在 t 里找到
        return si == s.Length;
    }
}
