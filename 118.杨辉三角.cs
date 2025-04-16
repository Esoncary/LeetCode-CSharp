/*
 * @lc app=leetcode.cn id=118 lang=csharp
 *
 * [118] 杨辉三角
 */

// @lc code=start
public class Solution118 {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> list = new List<IList<int>>();
        for( int i = 0 ; i< numRows; i++ )
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
        return list;
    }
}
// @lc code=end

