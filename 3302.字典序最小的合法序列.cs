class Solution3302
{
    public int[] ValidSequence(String word1, String word2)
    {
        char[] s = word1.ToCharArray();
        char[] t = word2.ToCharArray();
        int n = s.Length;
        int m = t.Length;

        int[] suf = new int[n + 1];
        suf[n] = m;
        int j = m - 1;

        for (int i = n - 1; i >= 0; i--)
        {
            if (j >= 0 && s[i] == t[j])
            {
                j--;
            }
            suf[i] = j + 1;
        }

        int[] ans = new int[m];
        bool changed = false; // 是否修改过
        j = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == t[j] || !changed && suf[i + 1] <= j + 1)
            {
                if (s[i] != t[j])
                {
                    changed = true;
                }
                ans[j++] = i;
                if (j == m)
                {
                    return ans;
                }
            }
        }
        return new int[] { };
    }
}
