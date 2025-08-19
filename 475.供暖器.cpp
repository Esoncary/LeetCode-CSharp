/*
 * @lc app=leetcode.cn id=475 lang=cpp
 *
 * [475] 供暖器
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
    int findRadius(vector<int> &houses, vector<int> &heaters)
    {
        sort(houses.begin(), houses.end());
        sort(heaters.begin(), heaters.end());

        auto check = [&](long long mid)
        {
            for (int i = 0, j = 0; i < houses.size(); i++)
            {
                /* code */
                while (j < heaters.size() && houses[i] > heaters[j] + mid)
                {
                    /* code */
                    j++;
                }
                if (j == heaters.size() || houses[i] < heaters[j] - mid)
                    return false;
            }
            return true;
        };

        int l = -1;
        int r = max(
                    abs(houses.back() - heaters.front()),
                    abs(heaters.back() - houses.front())) +
                1;

        while (l + 1 < r)
        {
            /* code */
            long long mid = l + (r - l) / 2;
            (check(mid) ? r : l) = mid;
        }
        return r;
    }
};
// @lc code=end
