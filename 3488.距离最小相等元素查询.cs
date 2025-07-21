
public class Solution2080
{
    public IList<int> SolveQueries(int[] nums, int[] queries)
    {
        // 步骤 1: 预处理，将相同值的索引聚合到列表中
        var indices = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!indices.ContainsKey(nums[i]))
            {
                indices[nums[i]] = new List<int>();
            }
            indices[nums[i]].Add(i);
        }

        int n = nums.Length;

        // 步骤 2: 为每个索引列表添加哨兵，以简化环形距离计算
        foreach (List<int> p in indices.Values)
        {
            // 如果列表只有一个元素，哨兵技巧不适用（且无意义），跳过
            if (p.Count <= 1)
            {
                continue;
            }

            // 记录原始的第一个和最后一个索引
            int firstOriginalIndex = p[0];
            int lastOriginalIndex = p[p.Count - 1];

            // 在列表头部插入代表环绕到“左边”的哨兵
            p.Insert(0, lastOriginalIndex - n);

            // 在列表尾部添加代表环绕到“右边”的哨兵
            p.Add(firstOriginalIndex + n);
        }

        var ans = new List<int>(queries.Length); // 预分配空间以提高性能

        // 步骤 3: 处理所有查询
        foreach (int i in queries)
        {
            List<int> p = indices[nums[i]];

            // 如果列表大小小于等于 1（原始大小），或在添加哨兵后为 3，
            // 说明没有其他相等的元素。
            // (原始大小为1 + 2个哨兵 = 3)
            if (p.Count <= 1 || p.Count == 3)
            {
                ans.Add(-1);
            }
            else
            {
                // 使用二分查找在排序的索引列表中找到当前查询索引的位置
                int j = p.BinarySearch(i);

                // 因为哨兵的存在，我们可以直接安全地访问 j-1 和 j+1
                // 来找到最近的两个相等元素（无论它们是否跨越数组的末尾）
                int dist1 = i - p[j - 1];
                int dist2 = p[j + 1] - i;
                ans.Add(Math.Min(dist1, dist2));
            }
        }
        return ans;
    }
}