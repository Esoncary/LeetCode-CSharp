/*
 * @lc app=leetcode.cn id=18 lang=csharp
 *
 * [18] 四数之和
 */

// @lc code=start
public class Solution18
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        int length = nums.Length;
        Array.Sort(nums);
        List<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < length - 3; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            long a = nums[i];
            if (a + nums[i + 1] + nums[i + 2] + nums[i + 3] > target) break;
            if (a + nums[length - 1] + nums[length - 2] + nums[length - 3] < target) continue;
            for (int j = i + 1; j < length - 2; j++)
            {
                if (j > 0 && nums[j] == nums[j - 1] && i != j - 1) continue;
                long b = nums[j];
                if (a + b + nums[j + 1] + nums[j + 2] > target) break;
                if (a + b + nums[length - 1] + nums[length - 2] < target) continue;
                //双指针
                int l = j + 1;
                int r = length - 1;
                // int c = nums[l] - 1;
                // int d = nums[r] - 1;
                while (l < r)
                {
                    // if (nums[l] == c && nums[r] == d)
                    // {
                    //     r--;
                    //     l++;
                    // }
                    // c = nums[l];
                    // d = nums[r];
                    if (nums[l] + nums[r] == target - a - b)
                    {
                        List<int> temp = new List<int>() { (int)a, (int)b, nums[l], nums[r] };
                        ans.Add(temp);
                        for (l++; l < r && nums[l - 1] == nums[l]; l++) ;
                        for (r--; l < r && nums[r + 1] == nums[r]; r--) ;
                    }
                    else if (nums[l] + nums[r] > target - a - b)
                    {
                        r--;
                    }
                    else
                    {
                        l++;
                    }
                }
            }
        }
        return ans;
    }
}
// @lc code=end

