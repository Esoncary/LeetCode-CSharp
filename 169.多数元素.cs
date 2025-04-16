/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */

// @lc code=start
public class Solution169 {
    public int MajorityElement(int[] nums) {
        //哈希表
        // Dictionary<int, int> dic = new Dictionary<int, int>();
        // for(int i = 0; i< nums.Length; i++)
        // {
        //     if(!dic.ContainsKey(nums[i]))
        //     {
        //         dic.Add(nums[i], 1);
        //     }
        //     else
        //     {
        //         dic[nums[i]] ++;
        //     }
            
        //     if(dic[nums[i]] > nums.Length / 2) return nums[i];
        // }
        // throw new InvalidOperationException("未找到多数元素，输入数组不符合要求。");
        
        //排序
        // Array.Sort(nums);
        // return nums[nums.Length/2];

        //摩尔投票算法
        //初始时nums的首个元素为majority，count=1
        //遇到不是majority的元素count--，如果count=0，则majority改为当前遍历到的元素
        int majority = nums[0];
        int count = 1;
        for(int i = 1; i< nums.Length; i++)
        {
            if(nums[i] != majority)
            {
                if(count == 0)
                {
                    majority = nums[i];
                    count = 1;
                }
                else
                {
                    count--;
                }
            }
            else
            {
                count++;
            }
        }
        return majority;
    }
}
// @lc code=end

