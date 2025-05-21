/*
 * @lc app=leetcode.cn id=3306 lang=csharp
 *
 * [3306] 元音辅音字符串计数 II
 */

// @lc code=start
public class Solution306
{
    public long CountOfSubstrings(string word, int k)
    {
        return Ans(word, k - 1) - Ans(word, k);
    }
    public long Ans(string word, int k)
    {
        char[] nums = word.ToCharArray();
        long length = nums.Length;
        long left = 0;
        long ans = 0;
        Dictionary<char, long> dic = new Dictionary<char, long>();
        long cnt = 0;
        for (long right = 0; right < length; right++)
        {
            //in
            char temp = nums[right];
            if ("aeiou".IndexOf(temp) >= 0)
            {
                if (!dic.ContainsKey(temp))
                    dic.Add(temp, 1);
                else
                {
                    dic[temp]++;
                }
            }
            else
            {
                cnt++;
            }

            while (dic.Count == 5 && cnt > k)
            {
                ans += length - right;
                char x = nums[left];
                if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')
                {
                    dic[x]--;
                    if (dic[x] == 0)
                        dic.Remove(x);
                }
                else
                {
                    cnt--;
                }
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

