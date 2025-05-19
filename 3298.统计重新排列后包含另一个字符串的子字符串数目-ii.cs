public class Solution3298
{
    public long ValidSubstringCount(string S, string T)
    {
        if (S.Length < T.Length)
        {
            return 0;
        }

        char[] s = S.ToCharArray();
        char[] t = T.ToCharArray();
        int[] diff = new int[26];

        foreach (char c in t)
        {
            diff[c - 'a']++;
        }

        int less = 0;
        foreach (int d in diff)
        {
            if (d > 0)
            {
                less++;
            }
        }

        long ans = 0;
        int left = 0;

        foreach (char c in s)
        {
            int idx = c - 'a';
            diff[idx]--;
            if (diff[idx] == 0)
            {
                less--;
            }

            while (less == 0)
            {
                char outChar = s[left++];
                int outIdx = outChar - 'a';
                if (diff[outIdx] == 0)
                {
                    less++;
                }
                diff[outIdx]++;
            }

            ans += left;
        }

        return ans;
    }
}
