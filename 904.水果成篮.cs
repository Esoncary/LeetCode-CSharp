/*
 * @lc app=leetcode.cn id=904 lang=csharp
 *
 * [904] 水果成篮
 */

// @lc code=start
public class Solution904
{
    public int TotalFruit(int[] fruits)
    {
        int length = fruits.Length;
        int left = 0;
        int count = 0;
        int ans = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int right = 0; right < length; right++)
        {
            //in
            if (!dic.ContainsKey(fruits[right]))
                dic.Add(fruits[right], 1);
            else
                dic[fruits[right]]++;
            count++;
            //out
            while (dic.Count > 2)
            {
                count--;
                dic[fruits[left]]--;
                if (dic[fruits[left]] <= 0)
                    dic.Remove(fruits[left]);
                left++;
            }
            //update
            ans = Math.Max(ans, count);
        }
        return ans;
    }
}
// @lc code=end

