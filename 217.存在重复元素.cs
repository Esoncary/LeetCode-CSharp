/*
 * @lc app=leetcode.cn id=217 lang=csharp
 *
 * [217] 存在重复元素
 */

// @lc code=start
public class Solution217
{
    public bool ContainsDuplicate(int[] nums)
    {
        //哈希1
        HashSet<int> hash = new HashSet<int>();
        // foreach (int i in nums)
        // {
        //     if (hash.Contains(i))
        //     {
        //         return true;
        //     }
        //     else
        //     {
        //         hash.Add(i);
        //     }
        // }
        // return false;
        //哈希2
        foreach (int i in nums)
        {
            hash.Add(i);
        }
        return hash.Count < nums.Length;
    }
}
// @lc code=end

