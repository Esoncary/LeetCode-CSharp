/*
 * @lc app=leetcode.cn id=275 lang=cpp
 *
 * [275] H 指数 II
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
    int hIndex(vector<int> &citations)
    {
        int n = citations.size();
        int l = 0;
        int r = n + 1;
        while (l + 1 < r)
        {
            int mid = (l + r) / 2;
            (citations[n - mid] >= mid ? l : r) = mid;
        }
        return l;
    }
};
// @lc code=end
