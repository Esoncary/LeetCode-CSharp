/*
 * @lc app=leetcode.cn id=1482 lang=cpp
 *
 * [1482] 制作 m 束花所需的最少天数
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
    int minDays(vector<int> &bloomDay, int m, int k)
    {
        if ((long long)m * k > bloomDay.size())
            return -1;
        int l = *min_element(bloomDay.begin(), bloomDay.end()) - 1;
        int r = *max_element(bloomDay.begin(), bloomDay.end()) + 1;
        while (l + 1 < r)
        {
            /* code */
            int mid = l + (r - l) / 2;
            (check(bloomDay, k, mid) >= m ? r : l) = mid;
        }
        return r;
    }

private:
    int check(vector<int> &bloomDay, int k, int mid)
    {
        int bouquets = 0;
        int flower = 0;
        for (int bloom : bloomDay)
        {
            /* code */
            if (mid >= bloom)
            {
                flower++;
                if (flower >= k)
                {
                    bouquets++;
                    flower = 0;
                }
            }
            else
            {
                flower = 0;
            }
        }
        return bouquets;
    }
};
// @lc code=end
