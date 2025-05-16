public class Solution632
{
    public int[] SmallestRange(IList<IList<int>> nums)
    {
        int k = nums.Count;
        int n = 0;
        foreach (var list in nums)
        {
            n += list.Count;
        }

        // 创建并填充合并数组
        int[][] pairs = new int[n][];
        int index = 0;
        for (int i = 0; i < k; i++)
        {
            foreach (int num in nums[i])
            {
                pairs[index++] = new int[] { num, i };
            }
        }

        // 按数值排序
        Array.Sort(pairs, (a, b) => a[0] - b[0]);

        // 滑动窗口初始化
        int left = 0;
        int minLeft = 0, minRight = int.MaxValue;
        int[] cnt = new int[k];
        int count = 0; // 记录当前窗口包含的不同列表数

        for (int right = 0; right < pairs.Length; right++)
        {
            int listId = pairs[right][1];
            if (cnt[listId] == 0)
            {
                count++;
            }
            cnt[listId]++;

            // 窗口包含所有列表时，尝试收缩左边界
            while (count == k && left <= right)
            {
                // 更新最小区间
                if (pairs[right][0] - pairs[left][0] < minRight - minLeft)
                {
                    minLeft = pairs[left][0];
                    minRight = pairs[right][0];
                }

                // 收缩左边界
                int leftListId = pairs[left][1];
                cnt[leftListId]--;
                if (cnt[leftListId] == 0)
                {
                    count--;
                }
                left++;
            }
        }

        return new int[] { minLeft, minRight };
    }
}