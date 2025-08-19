#include <iostream>
#include <vector>
#include <string>
#include <algorithm>
#include <numeric>
#include <limits>
#include <unordered_map>
#include <unordered_set>
#include <cmath>

using namespace std;
class Solution3296
{
public:
    long long minNumberOfSeconds(int mountainHeight, vector<int> &workerTimes)
    {
        auto check = [&](long long m)
        {
            int left_h = mountainHeight;
            for (int t : workerTimes)
            {
                left_h -= ((int)sqrt(m / t * 8 + 1) - 1) / 2;
                if (left_h <= 0)
                {
                    return true;
                }
            }
            return false;
        };

        int max_t = *max_element(workerTimes.begin(), workerTimes.end());
        int h = (mountainHeight - 1) / workerTimes.size() + 1;
        long long left = 0, right = (long long)max_t * h * (h + 1) / 2;
        while (left + 1 < right)
        {
            long long mid = (left + right) / 2;
            (check(mid) ? right : left) = mid;
        }
        return right;
    }
};
