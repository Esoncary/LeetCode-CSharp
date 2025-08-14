/*
 * @lc app=leetcode.cn id=1011 lang=cpp
 *
 * [1011] 在 D 天内送达包裹的能力
 */

// @lc code=start
#include <vector> // 包含 vector 头文件
#include <limits>
#include <numeric>
#include <algorithm>
using namespace std; // 使用 std 命名空间
class Solution1011
{
public:
    int shipWithinDays(vector<int> &weights, int days)
    {
        // 肯定要> weights中最大的数 =》l= max(weights) - 1
        // r = sum(weights)
        int l = *max_element(weights.begin(), weights.end());
        int r = accumulate(weights.begin(), weights.end(), 0);
        // 二分
        while (l < r)
        {
            int mid = l + (r - l) / 2;

            if (check(weights, mid) <= days)
            {
                // mid 是一个可行的解，但可能不是最小的。
                // 真正的解在 [l, mid] 区间内。
                r = mid;
            }
            else
            {
                // mid 是一个不可行的解（运力太小），
                // 真正的解一定在 [mid + 1, r] 区间内。
                l = mid + 1; // 【关键修正点】
            }
        }
        return r;
    }
    int check(vector<int> &weights, int capacity)
    {
        int days_needed = 1; // 至少需要1天
        int current_sum = 0; // 当前船上的货物总重
        for (int weight : weights)
        {
            if (current_sum + weight > capacity)
            {
                // 如果加上当前这个货物就超载了
                days_needed++;        // 那么需要新的一天
                current_sum = weight; // 新的一天从这个货物开始算
            }
            else
            {
                // 如果没超载，则将货物装上船
                current_sum += weight;
            }
        }
        return days_needed;
    }
};
// @lc code=end
