/*
 * @lc app=leetcode.cn id=2367 lang=csharp
 *
 * [2367] 等差三元组的数目
 */

// @lc code=start
public class Solution2367
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        // int ans = 0;
        // for (int i = 0; i < nums.Length - 2; i++)
        // {
        //     int check = nums[i];
        //     int j = i + 1;
        //     while (j < nums.Length - 1 && check + diff > nums[j])
        //     {
        //         if (nums[j] != check + diff)
        //         {
        //             j++;
        //         }
        //         else
        //         {
        //             break;
        //         }
        //     }
        //     if (j < nums.Length - 1 && check + diff != nums[j])
        //         continue;

        //     int k = j + 1;
        //     while (k < nums.Length && check + diff * 2 > nums[k])
        //     {
        //         if (nums[k] != check + diff * 2)
        //         {
        //             k++;
        //         }
        //         else
        //         {
        //             break;
        //         }
        //     }
        //     if (k < nums.Length && check + diff * 2 == nums[k])
        //         ans++;
        // }
        // return ans;

        // 哈希
        // int ans = 0;
        // List<int> list = new List<int>();
        // foreach (int item in nums)
        // {
        //     if (list.Contains(item - diff) && list.Contains(item - diff * 2))
        //         ans++;
        //     list.Add(item);
        // }
        // return ans;

        //三指针
        int ans = 0;
        int i = 0;
        int j = 1;
        foreach (int item in nums)
        {
            while (nums[j] + diff < item)
                ++j;
            if (nums[j] + diff > item)
                continue;
            // i = j + 1;
            while (nums[i] + diff * 2 < item)
                ++i;
            if (nums[i] + diff * 2 == item)
                ++ans;
        }
        return ans;
    }
}
// @lc code=end

