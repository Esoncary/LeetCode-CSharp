/*
 * @lc app=leetcode.cn id=2024 lang=csharp
 *
 * [2024] 考试的最大困扰度
 */

// @lc code=start
public class Solution
{
    public int MaxConsecutiveAnswers(string answerKey, int k)
    {
        char[] arr = answerKey.ToCharArray();
        int length = answerKey.Length;
        int left = 0;
        int sum = 0;
        int ans = 0;
        int count_t = 0;
        int count_f = 0;
        for (int right = 0; right < length; right++)
        {
            if (arr[right] == 'T')
                count_t++;
            else
                count_f++;
            sum++;
            while (count_f > k && count_t > k)
            {
                char x = arr[left];
                if (arr[left] == 'T')
                    count_t--;
                else
                    count_f--;
                sum--;
                left++;
            }
            ans = Math.Max(ans, sum);
        }
        return ans;
    }
}
// @lc code=end

