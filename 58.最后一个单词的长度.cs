/*
 * @lc app=leetcode.cn id=58 lang=csharp
 *
 * [58] 最后一个单词的长度
 */

// @lc code=start
public class Solution58 {
    public int LengthOfLastWord(string s) {
        string[] arr = s.Trim().Split(" ");
        return arr[arr.Length - 1].Length;
    }
}
// @lc code=end

