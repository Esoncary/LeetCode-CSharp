#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
using namespace std;

class Solution
{
public:
    int maximumLength(string s)
    {
        int n = s.size();
        int l = 0, r = n + 1; // 右边界取 n+1，覆盖所有可能长度

        while (l + 1 < r)
        {
            int mid = l + (r - l) / 2;
            if (check(mid, s) >= 3)
                l = mid;
            else
                r = mid;
        }

        return l == 0 ? -1 : l;
    }

    // 返回长度为 mid 的特殊子串出现次数的最大值
    int check(int mid, const string &s)
    {
        int cnt[26] = {0};
        int n = s.size();
        for (int i = 0; i < n;)
        {
            char c = s[i];
            int j = i;
            while (j < n && s[j] == c)
                j++;
            int len = j - i;
            if (len >= mid)
            {
                cnt[c - 'a'] += (len - mid + 1);
                if (cnt[c - 'a'] >= 3)
                    return cnt[c - 'a'];
            }
            i = j;
        }

        int best = 0;
        for (int k = 0; k < 26; ++k)
            best = max(best, cnt[k]);
        return best;
    }
};