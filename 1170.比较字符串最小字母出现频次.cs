/*
 * @lc app=leetcode.cn id=1170 lang=csharp
 *
 * [1170] 比较字符串最小字母出现频次
 */
// @lc code=start1170
public class Solution1170
{
    public int[] NumSmallerByFrequency(string[] queries, string[] words)
    {
        int m = words.Length, n = queries.Length;
        // 1. 计算 words 中每个单词的最小字母频次
        int[] fw = new int[m];
        for (int i = 0; i < m; i++)
            fw[i] = MinCharFreq(words[i]);
        Array.Sort(fw);  // O(m log m)

        // 2. 对每个 query，找第一个 > fq 的位置
        int[] ans = new int[n];
        for (int i = 0; i < n; i++)
        {
            int fq = MinCharFreq(queries[i]);
            int pos = LowerBound(fw, fq + 1);
            ans[i] = m - pos;
        }
        return ans;
    }

    // 求字符串 s 中最小字母出现频次
    private int MinCharFreq(string s)
    {
        char minc = s[0];
        // 找最小字母
        foreach (char c in s)
            if (c < minc) minc = c;
        // 统计次数
        int cnt = 0;
        foreach (char c in s)
            if (c == minc) cnt++;
        return cnt;
    }

    // lower_bound：返回数组中第一个 >= target 的下标
    private int LowerBound(int[] arr, int target)
    {
        int l = 0, r = arr.Length;
        while (l < r)
        {
            int mid = l + ((r - l) >> 1);
            if (arr[mid] >= target)
                r = mid;
            else
                l = mid + 1;
        }
        return l;
    }
}
// @lc code=end
