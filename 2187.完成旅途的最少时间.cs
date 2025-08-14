public class Solution
{
    public long MinimumTime(int[] time, int totalTrips)
    {
        int minT = int.MaxValue;
        foreach (var t in time)
        {
            minT = Math.Min(minT, t);
        }
        long left = minT - 1; // 循环不变量：check(left) 恒为 false
        long right = (long)minT * totalTrips; // 循环不变量：check(right) 恒为 true
        while (left + 1 < right)
        { // 开区间 (left, right) 不为空
            long mid = (left + right) >>> 1;
            if (check(mid, time, totalTrips))
            {
                right = mid; // 缩小二分区间为 (left, mid)
            }
            else
            {
                left = mid; // 缩小二分区间为 (mid, right)
            }
        }
        // 此时 left 等于 right-1
        // check(left) = false 且 check(right) = true，所以答案是 right
        return right; // 最小的 true
    }

    private bool check(long x, int[] time, int totalTrips)
    {
        long sum = 0;
        foreach (var t in time)
        {
            sum += x / t;
            if (sum >= totalTrips)
            {
                return true;
            }
        }
        return false;
    }
}
