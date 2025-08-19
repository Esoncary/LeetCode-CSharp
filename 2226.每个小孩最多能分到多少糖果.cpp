/*
 * @lc app=leetcode.cn id=2226 lang=cpp
 *
 * [2226] 每个小孩最多能分到多少糖果
 */

// @lc code=start
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <numeric>
#include <limits>
#include <unordered_map>
#include <unordered_set>

using namespace std;
class Solution
{
public:
    int maximumCandies(vector<int> &candies, long long k)
    {
        long long total = accumulate(candies.begin(), candies.end(), 0LL);
        if (total < k)
            return 0; // 总糖果数不够分，直接返回 0
        long long l = 0;
        long long r = *max_element(candies.begin(), candies.end()) + 1;
        while (l + 1 < r)
        {
            /* code */
            long long mid = l + (r - l) / 2;
            long long sum = 0;
            for (int candy : candies)
            {
                sum += candy / mid; // mid一堆 ，一共能分几堆
            }
            (sum >= k ? l : r) = mid;
        }
        return l;
    }
};
// @lc code=end
