/*
 * @lc app=leetcode.cn id=658 lang=csharp
 *
 * [658] 找到 K 个最接近的元素
 */

// @lc code=start
public class Solution658
{
    public IList<int> FindClosestElements(int[] arr, int k, int x)
    {
        int length = arr.Length;
        int left = 0;
        int right = length - 1;
        while (right - left + 1 > k)
        {
            int a = Math.Abs(arr[left] - x);
            int b = Math.Abs(arr[right] - x);
            if (a < b || (a == b && arr[left] < arr[right]))
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        List<int> ans = new List<int>();
        for (int i = left; i <= right; i++)
        {
            ans.Add(arr[i]);
        }
        return ans;
    }
}
// @lc code=end

