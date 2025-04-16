/*
 * @lc app=leetcode.cn id=119 lang=csharp
 *
 * [119] 杨辉三角 II
 */

// @lc code=start
public class Solution119 {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> list = new List<IList<int>>();
        for( int i = 0 ; i <= rowIndex; i++ )
        {
            list.Add(new List<int>());
            for( int j = 0; j <= i; j++ )
            {
                //第一个和最后一个元素设置为1
                if(j == 0 || j == i)
                {
                    list[i].Add(1);
                }
                else
                {
                    //中间元素设置
                    list[i].Add(list[i - 1][j] + list[i - 1][j - 1]);
                }
            }
        }
        return list[rowIndex];
    }
}
// @lc code=end

