/*
 * @lc app=leetcode.cn id=2594 lang=cpp
 *
 * [2594] 修车的最少时间
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
    long long repairCars(vector<int> &ranks, int cars)
    {
        int num = ranks.size();
        long long l = 0;
        long long r = 1LL * *min_element(ranks.begin(), ranks.end()) * cars * cars;
        while (l + 1 < r)
        {
            /* code */
            long long mid = l + (r - l) / 2;
            (check(ranks, mid) >= cars ? r : l) = mid;
        }
        return r;
    }

private:
    long long check(vector<int> &ranks, long long mid)
    {
        long long sum = 0;
        for (int rank : ranks)
        {
            // sum += rank * mid * mid;
            sum += (long long)sqrt(mid / rank); // 每个工人能修的车数
            if (sum > 1e9)
                break; // 防止溢出
        }
        return sum;
    }
};
// @lc code=end
