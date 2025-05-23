/*
 * @lc app=leetcode.cn id=2105 lang=csharp
 *
 * [2105] 给植物浇水 II
 */

// @lc code=start
public class Solution2105
{
    public int MinimumRefill(int[] plants, int capacityA, int capacityB)
    {

        int left = 0;
        int right = plants.Length - 1;
        int cnt = 0;
        int fullA = capacityA;
        int fullB = capacityB;
        while (left < right)
        {
            if (capacityA < plants[left])
            {
                cnt++;
                capacityA = fullA;
            }
            capacityA -= plants[left++];
            if (capacityB < plants[right])
            {
                cnt++;
                capacityB = fullB;
            }
            capacityB -= plants[right--];
        }
        if (left == right && Math.Max(capacityB, capacityA) < plants[left])
            cnt++;
        return cnt;
    }
}
// @lc code=end

