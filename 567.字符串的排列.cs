/*
 * @lc app=leetcode.cn id=567 lang=csharp
 *
 * [567] 字符串的排列
 */

// @lc code=start
public class Solution567

{
    public bool CheckInclusion(string s1, string s2)
    {
        // Dictionary<char, int> dic = new Dictionary<char, int>();
        // Dictionary<char, int> temp = new Dictionary<char, int>();
        // foreach (char item in s1)
        // {
        //     if (!dic.ContainsKey(item))
        //         dic.Add(item, 1);
        //     else
        //         dic[item]++;
        // }
        // for (int i = 0; i < s2.Length; i++)
        // {
        //     //in
        //     if (!temp.ContainsKey(s2[i]))
        //         temp.Add(s2[i], 1);
        //     else
        //         temp[s2[i]]++;
        //     if (i < s1.Length - 1)
        //         continue;
        //     //update
        //     if (AreDictionariesEqual<char, int>(dic, temp))
        //         return true;
        //     //out
        //     temp[s2[i - s1.Length + 1]]--;
        //     if (temp[s2[i - s1.Length + 1]] <= 0)
        //         temp.Remove(s2[i - s1.Length + 1]);
        // }
        // return false;
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        int n = s1.Length;
        int m = s2.Length;
        if (n > m)
        {
            return false;
        }
        foreach (char item in s1)
        {
            arr1[item - 'a']++;
        }
        for (int i = 0; i < m; i++)
        {
            //in
            arr2[s2[i] - 'a']++;
            if (i < n - 1)
                continue;
            //update
            if (arr1.SequenceEqual(arr2))
                return true;
            //out
            arr2[s2[i - n + 1] - 'a']--;
        }
        return false;

    }
    // public bool AreDictionariesEqual<TKey, TValue>(Dictionary<TKey, TValue> dict1, Dictionary<TKey, TValue> dict2)
    // {
    //     if (dict1.Count != dict2.Count)
    //     {
    //         return false;
    //     }

    //     foreach (var key in dict1.Keys)
    //     {
    //         if (!dict2.ContainsKey(key))
    //         {
    //             return false;
    //         }

    //         if (!EqualityComparer<TValue>.Default.Equals(dict1[key], dict2[key]))
    //         {
    //             return false;
    //         }
    //     }

    //     return true;
    // }
}
// @lc code=end

