public class Solution15
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        var res = new List<IList<int>>();
        Array.Sort(nums);
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            // 跳过重复的第一个数
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1, right = n - 1;
            int target = -nums[i];  // 我们要在 nums[left..right] 中找两个数之和 == target

            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum == target)
                {
                    // 找到一组解
                    res.Add(new List<int> { nums[i], nums[left], nums[right] });

                    // 跳过重复的第二个数
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    // 跳过重复的第三个数
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                { // sum > target
                    right--;
                }
            }
        }

        return res;
    }
}
