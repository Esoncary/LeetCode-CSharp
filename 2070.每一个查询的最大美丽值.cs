/*
 * @lc app=leetcode.cn id=2070 lang=csharp
 *
 * [2070] 每一个查询的最大美丽值
 */

// @lc code=start
public class Solution2070
{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        //排序 
        Array.Sort(items, (a, b) => a[0] - b[0]);
        for (int i = 1; i < items.Length; i++)
        {
            items[i][1] = Math.Max(items[i - 1][1], items[i][1]);
        }
        //二分
        for (int i = 0; i < queries.Length; i++)
        {
            int l = -1;
            int r = items.Length;
            while (l + 1 < r)
            {
                int mid = l + (r - l) / 2;
                if (items[mid][0] > queries[i])
                    r = mid;
                else
                    l = mid;
            }
            queries[i] = r != 0 ? items[r - 1][1] : 0;
        }
        //找到
        return queries;
    }
}
// @lc code=end

