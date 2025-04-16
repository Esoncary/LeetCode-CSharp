/*
 * @lc app=leetcode.cn id=566 lang=csharp
 *
 * [566] 重塑矩阵
 */

// @lc code=start
public class Solution566
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        int m = mat.GetLength(0);
        int n = mat[0].GetLength(0);
        if (m * n != r * c)
            return mat;
        //交错数组 和多维数组是不一样的
        int[][] ans = new int[r][];
        for (int i = 0; i < r; i++)
        {
            ans[i] = new int[c];
        }
        int matR = 0; int matC = 0;
        int ansR = 0; int ansC = 0;
        while (matR < m)
        {
            ans[ansR][ansC] = mat[matR][matC];
            ansC++;
            matC++;
            if (ansC >= c)
            {
                ansC = 0;
                ansR++;
            }
            if (matC >= n)
            {
                matC = 0;
                matR++;
            }
        }
        return ans;

    }
}
// @lc code=end

