/*
 * @lc app=leetcode.cn id=345 lang=csharp
 *
 * [345] 反转字符串中的元音字母
 */

// @lc code=start
public class Solution345
{
    public string ReverseVowels(string s)
    {
        //暴力
        // List<char> charList = new List<char>();
        // List<int> intList = new List<int>();
        // char[] arr = s.ToCharArray();
        // for (int i = 0; i < s.Length; i++)
        // {
        //     // if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U')
        //     if ("aeiouAEIOU".IndexOf(s[i]) >= 0)
        //     {
        //         charList.Add(s[i]);
        //         intList.Add(i);
        //     }
        // }
        // charList.Reverse();
        // for (int i = 0; i < intList.Count; i++)
        // {
        //     arr[intList[i]] = charList[i];
        // }
        // return new string(arr);

        //双指针
        int i = 0;
        int j = s.Length - 1;
        int n = s.Length;
        char[] arr = s.ToCharArray();
        while (i < j)
        {
            while (i < n && !isVowel(arr[i]))
            {
                ++i;
            }
            while (j > 0 && !isVowel(arr[j]))
            {
                --j;
            }
            if (i < j)
            {
                swap(arr, i, j);
                ++i;
                --j;
            }
        }
        return new String(arr);
    }
    public bool isVowel(char ch)
    {
        return "aeiouAEIOU".IndexOf(ch) >= 0;
    }

    public void swap(char[] arr, int i, int j)
    {
        char temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}
// @lc code=end

