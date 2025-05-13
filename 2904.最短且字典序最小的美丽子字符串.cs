/*
 * @lc app=leetcode.cn id=2904 lang=csharp
 *
 * [2904] 最短且字典序最小的美丽子字符串
 */

// @lc code=start
public class Solution
{
    public string ShortestBeautifulSubstring(string s, int k)
    {
        char[] arr = s.ToCharArray();
        int length = arr.Length;
        int left = 0;
        int count = 0;
        string ans = "";
        for (int right = 0; right < length; right++)
        {
            //in
            if (arr[right] == '1')
                count++;

            while (count == k && (arr[right] == '1' || right == length - 1))
            {
                //update
                string temp = s.Substring(left, right - left + 1);
                if (ans == "")
                    ans = temp;
                else
                {
                    if (ans.Length == temp.Length)
                        ans = ans.CompareTo(temp) > 0 ? temp : ans;
                    else
                        ans = ans.Length > temp.Length ? temp : ans;
                }

                //out
                if (arr[left] == '1')
                    count--;
                left++;
            }
        }
        return ans;
    }
}
// @lc code=end

