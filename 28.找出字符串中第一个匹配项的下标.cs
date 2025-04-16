/*
 * @lc app=leetcode.cn id=28 lang=csharp
 *
 * [28] 找出字符串中第一个匹配项的下标
 */

// @lc code=start
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

public class Solution28 {
    public int StrStr(string haystack, string needle) {
        return KMP(haystack,needle, computeTemporaryArray(needle));
    }

    public int[] computeTemporaryArray(string needle)
    {
        //构造临时数组存储前后缀匹配
        int j = 0; int i = 1;
        int[] suffix = new int[needle.Length];
        suffix[0] = 0;
        while(i <  needle.Length)
        {
            if(needle[j] == needle[i])
            {
                suffix[i] = j + 1;
                i++;
                j++;
            }else
            {
                if(j == 0)
                {
                    suffix[i] = 0;
                    i++;
                }else{
                    j = suffix[j - 1];
                }
            }
        }
        return suffix;
    }
    public int KMP(string haystack, string needle, int[] suffix)
    {
        //KMP算法
        int textIndex = 0; int patternIndex = 0;
        while(textIndex < haystack.Length)
        {
            if(haystack[textIndex] == needle[patternIndex])
            {
                textIndex++;
                patternIndex++;
                if(patternIndex == needle.Length)
                {
                    return textIndex - needle.Length;
                }
            }else{
                if(patternIndex == 0)
                {
                    textIndex ++;
                }else{
                    patternIndex = suffix[patternIndex - 1];
                }
            }
        } 
        return -1;
    }
}

// @lc code=end

