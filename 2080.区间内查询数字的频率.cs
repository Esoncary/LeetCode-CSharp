public class RangeFreqQuery2080
{
    // 存储每个值出现的位置列表
    private readonly Dictionary<int, List<int>> pos = new Dictionary<int, List<int>>();

    // public RangeFreqQuery(int[] arr)
    // {
    //     for (int i = 0; i < arr.Length; i++)
    //     {
    //         int v = arr[i];
    //         if (!pos.TryGetValue(v, out var list))
    //         {
    //             list = new List<int>();
    //             pos[v] = list;
    //         }
    //         list.Add(i);
    //     }
    // }

    // 返回 arr[left..right] 中 value 的出现次数
    public int Query(int left, int right, int value)
    {
        if (!pos.TryGetValue(value, out var list))
            return 0;

        // 统计在右边界 right 之前（含 right）的个数，等价于 lowerBound(right+1)
        int countRight = LowerBound(list, right + 1);
        // 统计在左边界 left 之前（含 left-1）的个数，等价于 lowerBound(left)
        int countLeft = LowerBound(list, left);
        return countRight - countLeft;
    }

    // 开区间版 lowerBound，返回第一个 >= target 的下标
    private int LowerBound(List<int> a, int target)
    {
        // 区间 (left, right)，初始为 (-1, a.Count)
        int left = -1;
        int right = a.Count;
        while (left + 1 < right)
        {
            // 不使用溢出风险低的写法
            int mid = left + ((right - left) >> 1);
            if (a[mid] < target)
                left = mid;  // 缩到 (mid, right)
            else
                right = mid; // 缩到 (left, mid)
        }
        return right;
    }
}
