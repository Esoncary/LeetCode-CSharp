class Solution2565
{
    public int MinimumScore(String S, String T)
    {
        char[] s = S.ToCharArray();
        char[] t = T.ToCharArray();
        int n = s.Length;
        int m = t.Length;

        int[] suf = new int[n + 1];
        suf[n] = m;
        int j = m - 1;
        //后缀
        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == t[j])
                j--;
            if (j < 0)
                return 0;
            suf[i] = j + 1;
        }
        int ans = suf[0];

        //前缀
        j = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == t[j])
            {
                j++;
                ans = Math.Min(ans, suf[i + 1] - j);
            }

        }
        return ans;


    }
}
