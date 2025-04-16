/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 */

// @lc code=start
public class Solution11
{
    public int MaxArea(int[] height)
    {
        int n = height.Length;
        // int max = int.MinValue;
        // for (int i = 0; i < n; i++)
        // {
        //     for (int j = i + 1; j < n; j++)
        //     {
        //         int temp = Math.Min(height[i], height[j]) * (j - i);
        //         max = max > temp ? max : temp;
        //     }
        // }
        // return max;
        int i = 0; int j = n - 1;
        int max = int.MinValue;
        while (i < j)
        {
            int temp = Math.Min(height[j], height[i]) * (j - i);
            max = max > temp ? max : temp;
            if (height[i] >= height[j])
                j--;
            else
            {
                i++;
            }
        }
        return max;
    }
}
// @lc code=end

