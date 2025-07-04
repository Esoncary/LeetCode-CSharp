/*
 * @lc app=leetcode.cn id=1887 lang=csharp
 *
 * [1887] 使数组元素相等的减少操作次数
 */

// @lc code=start
public class Solution1887
{
    public int ReductionOperations(int[] nums)
    {
        // Dictionary<int, int> dic = new Dictionary<int, int>();
        // foreach (var item in nums)
        // {
        //     if (!dic.ContainsKey(item))
        //         dic.Add(item, 1);
        //     else
        //         dic[item]++;
        // }
        // //按照key排序
        // SortedDictionary<int, int> sorted = new SortedDictionary<int, int>(dic);
        // int totalUnique = sorted.Count;
        // int ans = 0;
        // int idx = 0;

        // // 对每个唯一值，当前值需要降低到最小值的步数正好等于它在升序列表中的索引 idx
        // foreach (var kv in sorted)
        // {
        //     // idx 为从 0 开始的顺序号
        //     ans += kv.Value * idx;
        //     idx++;
        // }
        // return ans;
        int n = nums.Length;
        if (n <= 1) return 0;

        // 1. 排序
        Array.Sort(nums);

        int res = 0;  // 总操作次数
        int cnt = 0;  // 到当前位置，每个新值相对于最小值需要的操作次数

        // 2. 线性扫描
        for (int i = 1; i < n; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                // 碰到更大的新值，说明比它小的所有数都要多做一次操作
                cnt++;
            }
            res += cnt;
        }

        return res;
    }
}
// @lc code=end

