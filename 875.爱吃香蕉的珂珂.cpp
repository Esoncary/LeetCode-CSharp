/*
 * @lc app=leetcode.cn id=875 lang=cpp
 *
 * [875] 爱吃香蕉的珂珂
 */

// @lc code=start
#include <vector>
#include <numeric>
#include <algorithm>

using namespace std;

class Solution
{
public:
    int minEatingSpeed(vector<int> &piles, int h)
    {
        // 1. 确定二分查找的边界，使用开区间 (l, r)

        // 左边界 l：最后一个“不可行”的速度。速度 0 肯定是不可行的。
        long long l = 0;

        // 右边界 r：第一个“可能可行”的速度。
        // 一个绝对安全的上界是最大的一堆香蕉数量，因为以这个速度吃，
        // 每堆最多花1小时，总时间不会超过 piles.size()，而 h >= piles.size()。
        // 为了让 (l, r) 区间覆盖所有可能的答案，我们可以再加1。
        long long r = *max_element(piles.begin(), piles.end()) + 1;

        // 2. 二分查找
        // 循环直到 l 和 r 相邻
        while (l + 1 < r)
        {
            long long mid = l + (r - l) / 2;

            if (check(piles, mid) <= h)
            {
                // mid 是一个“可行”解。
                // 根据模板定义，r 需要更新为这个新的“已知可行解”。
                r = mid;
            }
            else
            {
                // mid 是一个“不可行”解 (速度太慢)。
                // 根据模板定义，l 需要更新为这个新的“已知不可行解”。
                l = mid;
            }
        }

        // 3. 返回结果
        // 循环结束时，l 是最大的不可行解，r 是最小的可行解。
        // 我们需要的是最小可行速度，所以返回 r。
        return r;
    }

private:
    // 辅助函数：计算在速度为 speed 时，吃完所有香蕉需要的小时数。
    // 使用 long long 防止时间总和溢出。
    long long check(const vector<int> &piles, long long speed)
    {
        // speed 为 0 是无效的，会导致除零错误。
        // 我们的二分查找左边界 l=0, mid 永远大于0，所以无需特殊处理。
        long long time_needed = 0;
        for (int pile : piles)
        {
            // (pile + speed - 1) / speed 是 pile/speed 向上取整的整数运算技巧。
            time_needed += (pile + speed - 1) / speed;
        }
        return time_needed;
    }
};
// @lc code=end