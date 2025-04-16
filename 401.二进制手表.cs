/*
 * @lc app=leetcode.cn id=401 lang=csharp
 *
 * [401] 二进制手表
 */

// @lc code=start
public class Solution401
{
    public IList<string> ReadBinaryWatch(int turnedOn)
    {
        IList<String> ans = new List<String>();
        for (int h = 0; h < 12; ++h)
        {
            for (int m = 0; m < 60; ++m)
            {
                if (BitCount(h) + BitCount(m) == turnedOn)
                {
                    ans.Add(h + ":" + (m < 10 ? "0" : "") + m);
                }
            }
        }
        return ans;
    }

    private static int BitCount(int i)
    {
        i = i - ((i >> 1) & 0x55555555);
        i = (i & 0x33333333) + ((i >> 2) & 0x33333333);
        i = (i + (i >> 4)) & 0x0f0f0f0f;
        i = i + (i >> 8);
        i = i + (i >> 16);
        return i & 0x3f;
    }
}
// @lc code=end

