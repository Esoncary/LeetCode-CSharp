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
        long long l = 0;
        long long r = *max_element(piles.begin(), piles.end()) + 1;

        while (l + 1 < r)
        {
            long long mid = l + (r - l) / 2;

            if (check(piles, mid) <= h)
            {
                r = mid;
            }
            else
            {
                l = mid;
            }
        }
        return r;
    }

private:
    long long check(const vector<int> &piles, long long speed)
    {
        long long time_needed = 0;
        for (int pile : piles)
        {
            time_needed += (pile + speed - 1) / speed;
        }
        return time_needed;
    }
};
// @lc code=end