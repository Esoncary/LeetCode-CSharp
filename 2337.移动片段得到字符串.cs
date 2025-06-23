/*
 * @lc app=leetcode.cn id=2337 lang=csharp
 *
 * [2337] 移动片段得到字符串
 */

// @lc code=start
public class Solution2337
{
    public bool CanChange(string start, string target)
    {
        int n = start.Length;
        int i = 0;
        int j = 0;
        while (i < n || j < n)
        {
            while (i < n && start[i] == '_')
                i++;
            while (j < n && target[j] == '_')
                j++;
            // 情况1：两者都遍历完，返回 true
            if (i == n && j == n) return true;

            // 情况2：其中一个遍历完，另一个未遍历完，返回 false
            if (i == n || j == n) return false;

            // 情况3：字符不匹配
            if (start[i] != target[j]) return false;

            // 情况4：L 不能右移，R 不能左移
            if (start[i] == 'L' && j > i) return false;
            if (start[i] == 'R' && j < i) return false;

            i++;
            j++;
        }
        return true;
    }
}
// @lc code=end

