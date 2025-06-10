/*
 * @lc app=leetcode.cn id=2122 lang=csharp
 *
 * [2122] 还原原数组
 */

// @lc code=start
public class Solution2122
{
    public int[] RecoverArray(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        int[] ans = new int[n / 2];
        for (int i = 1; i < n; i++)//枚举height的第一个
        {
            int diff = nums[i] - nums[0];
            if (diff % 2 == 1 || diff == 0) continue;
            int k = diff / 2;
            ans[0] = nums[0] + nums[i] >> 1;
            int idx = 1;
            int l = 1;//lower
            int r = i + 1;//heigher 肯定要比第一个height要大 

            bool[] visited = new bool[n];//标识heigher的数
            visited[i] = true;
            while (r < n)
            {
                while (l < n && visited[l]) l++;

                while (r < n && nums[r] - nums[l] < 2 * k) r++;
                if (r == n || nums[r] - nums[l] > 2 * k) break;

                visited[r] = true;
                ans[idx] = nums[l] + nums[r] >> 1;
                idx++;
                l++;
                r++;
            }
            if (idx == n / 2) return ans;
        }
        return ans;
    }
}
// @lc code=end

