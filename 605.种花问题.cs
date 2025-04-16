/*
 * @lc app=leetcode.cn id=605 lang=csharp
 *
 * [605] 种花问题
 */

// @lc code=start
public class Solution605
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        // int countZ = 0;//连续0的个数
        // int countF = 0;//已经可种植的花数
        // bool flag = false;
        // for (int i = 0; i < flowerbed.Length; i++)
        // {
        //     if (flowerbed[i] == 0)
        //     {
        //         countZ++;
        //         if (i == 0 || i == flowerbed.Length - 1)
        //             flag = true;
        //     }
        //     else if (flowerbed[i] == 1 && !flag)
        //     {
        //         countF += countZ > 0 ? (countZ + 1) / 2 - 1 : 0;
        //         countZ = 0;
        //     }
        //     else
        //     {
        //         countF += countZ / 2;
        //         flag = false;
        //         countZ = 0;
        //     }
        // }
        // if (flowerbed[flowerbed.Length - 1] == 0)
        //     countF += countZ == flowerbed.Length ? (countZ + 1) / 2 : countZ / 2;
        // return countF >= n;


        int count = 0;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            // 检查当前位置是否可以种花
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
            {
                flowerbed[i] = 1; // 种下花
                count++; // 可种花数量加 1
                i++; // 跳过下一个位置
            }
        }
        return count >= n;

    }
}
// @lc code=end

