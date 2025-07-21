class Solution3255
{
    public int[] ResultsArray(int[] nums, int k)
    {
        int[] ans = new int[nums.Length - k + 1];
        Array.Fill(ans, -1);
        int cnt = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            cnt = i == 0 || nums[i] == nums[i - 1] + 1 ? cnt + 1 : 1;
            if (cnt >= k)
            {
                ans[i - k + 1] = nums[i];
            }
        }
        return ans;
    }
}
