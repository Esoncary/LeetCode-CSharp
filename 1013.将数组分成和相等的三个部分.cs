/*
 * @lc app=leetcode.cn id=1013 lang=csharp
 *
 * [1013] 将数组分成和相等的三个部分
 */

// @lc code=start
public class Solution1013
{
    public bool CanThreePartsEqualSum(int[] arr)
    {
        // int total = arr.Sum();
        // if (total % 3 != 0)
        //     return false;
        // int avg = total / 3;
        // int curSum = 0;
        // int partIndex = 0;
        // foreach (int item in arr)
        // {
        //     curSum += item;
        //     if (curSum == avg)
        //     {
        //         curSum = 0;
        //         partIndex++;
        //     }
        // }
        // //如果有4部分能等于avg，那么 4 * avg != total,与前提相悖
        // return partIndex >= 3;

        //双指针
        int total = arr.Sum();
        if (total % 3 != 0)
            return false;
        int avg = total / 3;
        int left = 0;
        int right = arr.Length - 1;
        int leftSum = arr[left];
        int rightSum = arr[right];
        //防止把ar分为两部分 如【1，-1，1，-1】
        while (left + 1 < right)
        {
            if (leftSum == avg && rightSum == avg)
                return true;
            if (leftSum != avg)
            {
                left++;
                leftSum += arr[left];
            }

            if (rightSum != avg)
            {
                right--;
                rightSum += arr[right];
            }
        }
        return false;

    }
}
// @lc code=end

