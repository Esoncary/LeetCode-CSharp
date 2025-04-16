using System;
using System.Collections.Generic;

public class Solution697
{
    public int FindShortestSubArray(int[] nums)
    {
        Dictionary<int, int[]> dic = new Dictionary<int, int[]>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                // 存储元素第一次出现的索引、最后一次出现的索引和出现次数
                dic.Add(nums[i], new int[] { i, i, 1 });
            }
            else
            {
                dic[nums[i]][1] = i;
                dic[nums[i]][2]++;
            }
        }
        int maxD = 0;
        int minL = int.MaxValue;
        foreach (KeyValuePair<int, int[]> item in dic)
        {
            int n = item.Value[2];
            if (n > maxD)
            {
                maxD = n;
                minL = int.MaxValue;
            }
            maxD = n > maxD ? n : maxD;
            if (n == maxD)
            {
                int length = item.Value[1] - item.Value[0] + 1;
                minL = length < minL ? length : minL;
            }
        }
        return minL;
    }
}
