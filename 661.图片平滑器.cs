/*
 * @lc app=leetcode.cn id=661 lang=csharp
 *
 * [661] 图片平滑器
 */

// @lc code=start
public class Solution661
{
    public int[][] ImageSmoother(int[][] img)
    {
        int m = img.GetLength(0);
        int n = img[0].GetLength(0);
        int p = 0;//行
        int q = 0;//列
        int sum = 0;
        int count = 0;
        int[][] ans = new int[m][];
        for (int i = 0; i < m; i++)
        {
            ans[i] = new int[n];
        }
        while (p < m)
        {
            sum += img[p][q];
            count++;
            if (p + 1 < m)
            {
                sum += img[p + 1][q];
                count++;
            }
            if (q + 1 < n)
            {
                sum += img[p][q + 1];
                count++;
            }
            if (p + 1 < m && q + 1 < n)
            {
                sum += img[p + 1][q + 1];
                count++;
            }
            if (p - 1 >= 0)
            {
                sum += img[p - 1][q];
                count++;
            }
            if (q - 1 >= 0)
            {
                sum += img[p][q - 1];
                count++;
            }
            if (p - 1 >= 0 && q - 1 >= 0)
            {
                sum += img[p - 1][q - 1];
                count++;
            }
            if (p - 1 >= 0 && q + 1 < n)
            {
                sum += img[p - 1][q + 1];
                count++;
            }
            if (p + 1 < m && q - 1 >= 0)
            {
                sum += img[p + 1][q - 1];
                count++;
            }
            ans[p][q] = sum / count;
            q++;
            sum = 0;
            count = 0;
            if (q >= n)
            {
                q = 0;
                p++;
            }
        }
        return ans;
    }
}
// @lc code=end

