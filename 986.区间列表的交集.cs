/*
 * @lc app=leetcode.cn id=986 lang=csharp
 *
 * [986] 区间列表的交集
 */

// @lc code=start
public class Solution986
{
    public int[][] IntervalIntersection(int[][] firstList, int[][] secondList)
    {
        int n1 = firstList.Length;
        int n2 = secondList.Length;
        int i = 0;
        int j = 0;
        List<int[]> ans = new List<int[]>();
        while (i < n1 && j < n2)
        {
            // if (firstList[i][1] < secondList[j][0])
            // {
            //     i++;
            // }
            // else if (firstList[i][0] > secondList[j][1])
            // {
            //     j++;
            // }
            // else if (firstList[i][0] >= secondList[j][0])
            // {
            //     if (firstList[i][1] > secondList[j][1])
            //     {
            //         ans.Add(new int[] { firstList[i][0], secondList[j][1] });
            //         j++;
            //     }
            //     else
            //     {
            //         ans.Add(new int[] { firstList[i][0], firstList[i][1] });
            //         i++;
            //     }
            // }
            // else if (firstList[i][0] < secondList[j][0])
            // {
            //     if (firstList[i][1] > secondList[j][1])
            //     {
            //         ans.Add(new int[] { secondList[j][0], secondList[j][1] });
            //         j++;
            //     }
            //     else
            //     {
            //         ans.Add(new int[] { secondList[j][0], firstList[i][1] });
            //         i++;
            //     }
            // }


            int lo = Math.Max(firstList[i][0], secondList[j][0]);
            int hi = Math.Min(firstList[i][1], secondList[j][1]);
            if (lo <= hi)
                ans.Add(new int[] { lo, hi });

            // Remove the interval with the smallest endpoint
            if (firstList[i][1] < secondList[j][1])
                i++;
            else
                j++;


        }
        return ans.ToArray();
    }
}
// @lc code=end

