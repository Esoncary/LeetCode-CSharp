public class Solution80
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        int l = 2;
        int r = 2;

        while (r < n)
        {
            if (nums[r] != nums[l - 2])
            {
                nums[l++] = nums[r];
            }
            r++;
        }
        return Math.Min(l, n);
    }
}